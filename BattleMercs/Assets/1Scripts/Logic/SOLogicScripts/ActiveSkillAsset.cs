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
      
      /// <summary>
      /// Check Skill Enabled Status
      /// </summary>
      /// <param name="skillVisual"></param>
      /// <param name="selectSkillTargetVisual"></param>
      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         var skillEnabledStatus = skillVisual.SkillLogicReference.SkillAttributes.SkillEnableStatus;
         
         skillEnabledStatus.StartSkillTargetingVisual(skillVisual,selectSkillTargetVisual);
      }
      
      public override void EnableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.CooldownGraphic.enabled = true;
         
      }
      
      public override void DisableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.CooldownGraphic.enabled = false;
         heroPreviewSkill.CooldownText.text = "Ready!";
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
      
      public override void UpdateSkillSpeedText(ISkillVisual skillVisual, int speedValue)
      {
         skillVisual.SpeedText.text = speedValue <= 0 ? "" : speedValue.ToString();
      }
      
      public override void UpdateSkillCooldownText(ISkillVisual skillVisual,int skillCooldown)
      {
         skillVisual.CooldownText.text = skillCooldown <= 0 ? "" : skillCooldown.ToString();
      }

      #endregion
   }
}
