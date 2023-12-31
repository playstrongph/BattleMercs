using System.Collections.Generic;
using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class ArrowLineAndCrossHairVisual : MonoBehaviour, IArrowLineAndCrossHairVisual
   {
      #region VARIABLES
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingVisual))] private Object skillTargetingVisual = null;
      
      [Header("Constants")]
      [SerializeField] private float distanceMultiplier = 40f;
      
      //This determines the scale of the nodes
      [SerializeField] private float scaleFactor = 1f;
   
      //This 'normalizes' the distance to be used as an index
      [SerializeField] private float distanceDivisor = 30f;
   
      //This is a factor used in the bezier Curve calculations
      [SerializeField] private float tFactor = 0.08f;
      
      //OTHER VARIABLES
      
      //Integer difference between current mouse position and the skill visual position
      private int _intDifference = 0;
      private readonly List<Vector3> _controlPoints = new List<Vector3>();
      private readonly List<GameObject> _arrowNodes = new List<GameObject>();

      #endregion
        
      #region PROPERTIES
      
      public ISkillTargetingVisual SkillTargetingVisual => skillTargetingVisual as ISkillTargetingVisual;

      #endregion
        
      #region METHODS
      
      private void Awake()
      {
         var nodes = SkillTargetingVisual.Nodes;
         
         //Create Bezier Curve control points - P0,P1, and P2
         for (int i = 0; i < 3; i++)
         {
            _controlPoints.Add(Vector3.zero);
         }

         foreach (var node in nodes)
         {
            _arrowNodes.Add(node.gameObject);
         }
      }

      public void ShowArrowLineAndCrossHair()
      {
         //where the mouse currently is
         var thisTransform = transform;
      
         //SkillTargeting position is the skill visual's position
         var notNormalized = thisTransform.position - SkillTargetingVisual.ThisTransform.position;
      
         var direction = notNormalized.normalized;
      
         var distanceFromHero = (direction*distanceMultiplier).magnitude;
      
         var difference = notNormalized.magnitude - distanceFromHero;
      
         var distanceLimit = 0f;  //default value is zero
      
         _intDifference = Mathf.RoundToInt(difference);
         
         if (_intDifference > distanceLimit)  //if there is some distance between skill position and mouse position
         {
            ShowTargetingArrow(notNormalized,direction);
            
            //TODO: Temp disabled
            ShowTargetingArrowNodes();
         
            //Enable Box Collider
            SkillTargetingVisual.Draggable.ArrowCollider.enabled = true;

            //TODO: Show cross hair for valid targets
            ShowTargetCrossHair();

         }
         else  //if there is NO distance between skill position and mouse position
         {
            //Disable Box Collider
            SkillTargetingVisual.Draggable.ArrowCollider.enabled = false;
            
            //Hide the targeting Arrow
            ArrowImageOff();
            
            //Hide the targeting nodes
            AllNodeImagesOff();
         
            //Hide the CrossHair
            CrossHairImageOff();
         }
      }
      
      private void ShowTargetingArrow(Vector3 notNormalized, Vector3 direction)
      {
         var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
         var arrow = SkillTargetingVisual.Arrow.gameObject;
      
         //Show arrow and nodes
         ArrowImageOn();
      
         //Set the arrow position to the current mouse position
         arrow.gameObject.transform.position = transform.position - 15f * direction;
      
         //Set the arrow rotation to the direction of the target from the origin
         arrow.gameObject.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
      }
      
      private void ShowTargetingArrowNodes()
   {
      //Transform where the mouse currently is
      var mouseTransform = transform;

      //P0 is where the mouse is at
      _controlPoints[2] = mouseTransform.position;
           
      //P2 is where the source (skill parent) is at
      _controlPoints[0] = SkillTargetingVisual.ThisTransform.position;

      //Halfway between P0 and P2, with a height of Z
      _controlPoints[1] =
         _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);
      
      
      //Varying index based on _arrowNodes count and distance
      var nodeIndex = Mathf.Floor(Mathf.RoundToInt(_intDifference / distanceDivisor));
      
      
      //Clamp the Node index
      nodeIndex = Mathf.Clamp(nodeIndex, 1, _arrowNodes.Count);

      
      for (int k = 0; k < _arrowNodes.Count; k++)
      {
         var indexTracker = 0;
         
         for (int i = 0; i < nodeIndex; i++)
         {
            indexTracker = i;
            
            //Turns on image of node index i
            NodeImageOn(i);

            //Values determined through trial and error
            var t = (i+ tFactor) / ((nodeIndex - 1) + 1f);  //Use the number of nodes enabled by the distance

            //Quadratic Bezier Curve
            _arrowNodes[i].transform.position =
               Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
               2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
               Mathf.Pow(t, 2) * _controlPoints[2];                //t^2*P2


            //Calculates rotation for each arrow node
            if (i>0)
            {
               var euler = new Vector3(0, 0, 
                  Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - _arrowNodes[i - 1].transform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
            }
            else
            {
               var euler = new Vector3(0, 0, 
                  Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - SkillTargetingVisual.ThisTransform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
            }

            //calculates scales for each arrow node
            var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
            _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);
         }

         if (k != indexTracker)
         {
            NodeImageOff(k);
         }
      }

   }
      
      private void ShowTargetCrossHair()
            {
               // ReSharper disable once PossibleNullReferenceException
               var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      
               //Store at most 5 ray cast hits
               var mResults = new RaycastHit[5];
      
               //ray traverses all layers
               var layerMask = ~0;
      
               //Same to RayCastAll but with no additional garbage
               int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity, layerMask);
               
               //Hide CrossHair by default
               CrossHairImageOff();

               for (int i = 0; i < hitsCount; i++)
               {
                  var heroVisualTarget = mResults[i].transform.GetComponent<IHeroVisual>();
                  var skillTarget = SkillTargetingVisual.SkillVisualReference.SkillLogicReference.SkillAttributes
                        .SkillTarget;
                  var casterHero = SkillTargetingVisual.SkillVisualReference.SkillLogicReference.SkillInformation
                        .CasterHero;
                  var validHeroTargets = skillTarget.GetSkillTargets(casterHero);

                  if(heroVisualTarget != null)
                        if (validHeroTargets.Contains(heroVisualTarget.HeroLogicReference))
                        {
                           CrossHairImageOn();
                           SkillTargetingVisual.CrossHairImage.transform.position = heroVisualTarget.Transform.position;
                        }
                  
               }

            }
      

      private void ArrowImageOn()
      {
         SkillTargetingVisual.ArrowImage.enabled = true;
      }
      
      private void NodeImageOn(int index)
      {
         SkillTargetingVisual.NodesImage[index].enabled = true;
      }
      
      private void CrossHairImageOn()
      {
         SkillTargetingVisual.CrossHairImage.enabled = true;
      }
      
      private void ArrowImageOff()
      {
         SkillTargetingVisual.ArrowImage.enabled = false;
      }

      private void NodeImageOff(int index)
      {
         SkillTargetingVisual.NodesImage[index].enabled = false;
      }
      
      private void AllNodeImagesOff()
      {
         var nodeImages = SkillTargetingVisual.NodesImage;

         foreach (var nodeImage in nodeImages)
         {
            nodeImage.enabled = false;
         }
      }

      private void CrossHairImageOff()
      {
         SkillTargetingVisual.CrossHairImage.enabled = false;
      }


      #endregion
   }
}
