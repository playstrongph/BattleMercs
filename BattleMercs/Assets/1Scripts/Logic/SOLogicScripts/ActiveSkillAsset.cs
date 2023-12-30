using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "ActiveSkill", menuName = "Assets/SkillType/ActiveSkill")]
   public class ActiveSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         //TODO: Call SkillEnabled.StartSkillTargetingVisual(skillVisual)
      }
      
      public override void SetPreviewSkillCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.CooldownGraphic.enabled = true;
      }
      
      public override void SetSkillPreviewCooldownGraphic(ISkillPreviewVisual skillPreview)
      {
         skillPreview.CooldownGraphic.enabled = true;
      }
      
      public override void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
         //Check if skill is ready or not ready
         skillVisual.SkillLogicReference.SkillAttributes.SkillReadiness.UpdateSkillReadinessVisual(skillVisual);
         
      }
      
      public override void UpdateSkillSpeedText(ISkillVisual skillVisual)
      {
         var skillSpeed = skillVisual.SkillLogicReference.SkillAttributes.SkillSpeed;

         skillVisual.SpeedText.text = skillSpeed <= 0 ? "" : skillSpeed.ToString();
      }
      
      public override void UpdateSkillCooldownText(ISkillVisual skillVisual)
      {
         var skillCooldown = skillVisual.SkillLogicReference.SkillAttributes.SkillCooldown;

         skillVisual.CooldownText.text = skillCooldown <= 0 ? "" : skillCooldown.ToString();
      }

      #endregion
   }
}
