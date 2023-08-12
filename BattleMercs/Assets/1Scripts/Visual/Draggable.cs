using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class Draggable : MonoBehaviour, IDraggable
   {
      #region VARIABLES

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingVisual))] private Object skillTargetingVisual = null;
      [SerializeField]  private Camera cameraUsed = null;

      [Header("Components")] 
      [SerializeField] private BoxCollider arrowCollider = null;
     
      
      //private variables
      private readonly Vector3 _pointerDisplacement = Vector3.zero;
      private readonly float _zDisplacement = 0f;
     
      
      private delegate void ShowSkillTargeting();
      private ShowSkillTargeting _skillTargeting;
      
      #endregion

      #region PROPERTIES
      
      public BoxCollider ArrowCollider => arrowCollider;
      
      private ISkillTargetingVisual SkillTargetingVisual => skillTargetingVisual as ISkillTargetingVisual;
      private Camera CameraUsed => cameraUsed;
      
      #endregion

      #region METHODS
      
      private void Awake()
      {
         _skillTargeting = NoAction;
      }

      private void Update()
      {
         _skillTargeting();
      }
      
      
      /// <summary>
      /// Convert the mouse coordinates into world coordinates
      /// </summary>
      /// <returns></returns>
      private Vector3 MouseInWorldCoords()
      {
         var screenMousePos = Input.mousePosition;
         screenMousePos.z = _zDisplacement;
         return CameraUsed.ScreenToWorldPoint(screenMousePos);
         //return Camera.main.ScreenToWorldPoint(screenMousePos);
      }
      
      /// <summary>
      /// Enables draggable script
      /// specifically, the update method
      /// </summary>
      public void EnableDraggable()
      {
         this.enabled = true;
         _skillTargeting = UpdateAction;
      }
      
      /// <summary>
      /// Disables the draggable script
      /// prevents the Update method from running continuously
      /// </summary>
      public void DisableDraggable()
      {
         _skillTargeting = NoAction;
         this.enabled = false;
      }
      
      private void UpdateAction()
      {
         var mousePos = MouseInWorldCoords();    
         var thisTransform = this.transform;
            
         thisTransform.position = new Vector3(mousePos.x - _pointerDisplacement.x, mousePos.y - _pointerDisplacement.y, thisTransform.position.z);
         
         //TODO:
         SkillTargetingVisual.ArrowLineAndCrossHairVisual.ShowArrowLineAndCrossHair();
      }
      
      
      
      
      
      
      
      /// <summary>
      /// Dummy method used by _skillTargeting in order not to needlessly run logic in Update
      /// </summary>
      private void NoAction() {}
      
      

      #endregion
   }
}
