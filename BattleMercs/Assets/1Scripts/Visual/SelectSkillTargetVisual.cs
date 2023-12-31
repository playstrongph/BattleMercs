using UnityEngine;

namespace _1Scripts.Visual
{
   public class SelectSkillTargetVisual : MonoBehaviour, ISelectSkillTargetVisual
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingVisual))] private Object skillTargetingVisual = null;
        

      #endregion
        
      #region PROPERTIES

      public ISkillTargetingVisual SkillTargetingVisual => skillTargetingVisual as ISkillTargetingVisual;  

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Start skill targeting permissive checks (SkillType, EnableStatus, and ReadinessStatus)
      /// </summary>
      /// <param name="skillVisual"></param>
      public void SkillTargetingPermissiveChecks(ISkillVisual skillVisual)
      {

         var skillType = skillVisual.SkillLogicReference.SkillAttributes.SkillType;
         //TODO: Replace this with permissive checks for SkillType, SkillEnableStatus, SkillReadinessStatus
         //StartSkillTargeting(skillVisual);
         
         skillType.StartSkillTargetingVisual(skillVisual, this);

      }
      
      /// <summary>
      /// Start Skill Targeting after skill targeting permissive checks (SkillType, EnableStatus, and ReadinessStatus)
      /// </summary>
      /// <param name="skillVisual"></param>
      public void StartSkillTargeting(ISkillVisual skillVisual)
      {
         SkillTargetingVisual.ThisTransform.position = skillVisual.ThisTransform.position;
         SkillTargetingVisual.Draggable.EnableDraggable();
      }



      #endregion
   }
}
