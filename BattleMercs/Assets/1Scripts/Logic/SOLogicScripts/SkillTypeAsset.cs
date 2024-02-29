using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillTypeAsset : ScriptableObject, ISkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public virtual void StartSkillTargetingVisual(ISkillVisual skillVisual, ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         
      }

      public virtual void SetPreviewSkillCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         //Enabled image for active skills
         //Disable image for basic and passive skills
      }
      
      public virtual void SetSkillPreviewCooldownGraphic(ISkillPreviewVisual skillPreview)
      {
         //Enabled image for active skills
         //Disable image for basic and passive skills
      }

      public virtual void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
         //Active Skill - check skill readiness status 
         //Passive Skill - Set Passive skill canvas enabled, others disabled
         //Basic Skill - Set Skill Ready Canvas enabled, others disabled
      }


      public virtual void UpdateSkillSpeedText(ISkillVisual skillVisualReference, int speedValue)
      {
         
      }
      
      public virtual void UpdateSkillCooldownText(ISkillVisual skillVisualReference, int skillCooldown)
      {

      }





      #endregion
   }
}
