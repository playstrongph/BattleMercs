using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class SkillTargetingVisual : MonoBehaviour, ISkillTargetingVisual
   {
      #region VARIABLES

      #pragma warning disable 0649
      [Header("Runtime References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisualReference;
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISelectSkillTargetVisual))] private Object selectSkillTargetVisual;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IArrowLineAndCrossHairVisual))] private Object arrowLineAndCrossHairVisual;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable;

      [Header("Transforms")]
      [SerializeField] private Transform arrow;
      [SerializeField] private List<Transform> nodes = new List<Transform>();
      
      [Header("Images")] 
      [SerializeField] private Image crossHairImage;
      [SerializeField] private Image arrowImage;
      [SerializeField] private List<Image> nodesImage = new List<Image>();
      
      //Other variables

      private Vector3 SkillTargetingOrigin { get; set; }
   
      #pragma warning restore 0649
      
      #endregion

      #region PROPERTIES

      public ISkillVisual SkillVisualReference
      {
         get => skillVisualReference as ISkillVisual;
         set => skillVisualReference = value as Object;
      }
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;
      public ISelectSkillTargetVisual SelectSkillTargetVisual => selectSkillTargetVisual as ISelectSkillTargetVisual;
      public IArrowLineAndCrossHairVisual ArrowLineAndCrossHairVisual => arrowLineAndCrossHairVisual as IArrowLineAndCrossHairVisual;
      public IDraggable Draggable => draggable as IDraggable;
      public Transform Arrow => arrow;
      public List<Transform> Nodes => nodes;

      public Transform ThisTransform => transform;


      public Image CrossHairImage => crossHairImage;
      public Image ArrowImage => arrowImage;
      public List<Image> NodesImage => nodesImage;


      #endregion

      #region METHODS

      private void Awake()
      {
         SkillTargetingOrigin = transform.position;
      }

      /// <summary>
      /// Displays skill targeting
      /// </summary>
      public void StartTargeting(ISkillVisual skillVisual)
      {
         SelectSkillTargetVisual.SkillTargetingPermissiveChecks(skillVisual);
      }
      
      /// <summary>
      /// Turns off skill targeting display
      /// </summary>
      /// <param name="skillVisual"></param>
      public void StopTargeting(ISkillVisual skillVisual)
      {
         ResetPositionToOrigin();
         Draggable.DisableDraggable();
         skillVisual.SkillLogicReference.SkillAttributes.SkillTarget.HideHeroGlows(skillVisual.SkillLogicReference.SkillInformation.CasterHero);
      }

      /// <summary>
      /// Resets the Skill Targeting Visual to original position
      /// </summary>
      private void ResetPositionToOrigin()
      {
         ThisTransform.position = SkillTargetingOrigin;
      }
      
      public void ShowSkillTargetHeroGlows()
      {
         var skillTargetType = SkillVisualReference.SkillLogicReference.SkillAttributes.SkillTarget;
         var casterHero = SkillVisualReference.SkillLogicReference.SkillInformation.CasterHero;

         skillTargetType.ShowHeroGlows(casterHero);
      }

      

      #endregion
   }
}
