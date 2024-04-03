using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "PassiveSkill", menuName = "Assets/SkillType/PassiveSkill")]
   public class PassiveSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         //Do Nothing
      }
      
      public override void EnableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.CooldownGraphic.enabled = false;
         
      }
      
      public override void DisableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.CooldownGraphic.enabled = false;
         heroPreviewSkill.CooldownText.text = "";
      }
      
      public override void SetSkillPreviewCooldownGraphic(ISkillPreviewVisual skillPreview)
      {
         skillPreview.CooldownGraphic.enabled = false;
      }
      
      public override void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
 
         //Passive Skill - Set Passive skill canvas enabled, others disabled
         skillVisual.PassiveSkillCanvas.enabled = true;
         
         skillVisual.SkillReadyCanvas.enabled = false;
         skillVisual.SkillNotReadyCanvas.enabled = false;

      }
      
      public override void UpdateSkillSpeedText(ISkillVisual skillVisual, int speedValue)
      {
         skillVisual.SpeedText.text = ""; 
      }
      
      public override void UpdateSkillCooldownText(ISkillVisual skillVisual, int skillCooldown)
      {
         skillVisual.PassiveSkillCooldownText.text = skillCooldown <= 0 ? "" : skillCooldown.ToString();
      }

      #endregion
   }
}
