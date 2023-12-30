using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BasicSkill", menuName = "Assets/SkillType/BasicSkill")]
   public class BasicSkillAsset : SkillTypeAsset
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
         heroPreviewSkill.CooldownGraphic.enabled = false;
      }
      
      public override void SetSkillPreviewCooldownGraphic(ISkillPreviewVisual skillPreview)
      {
         skillPreview.CooldownGraphic.enabled = false;
      }
      
      public override void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
 
         //Basic Skill Settings
         skillVisual.SkillReadyCanvas.enabled = true;
         
         skillVisual.PassiveSkillCanvas.enabled = false;
         skillVisual.SkillNotReadyCanvas.enabled = false;
      }
      
      public override void UpdateSkillSpeedText(ISkillVisual skillVisual)
      {
         skillVisual.SpeedText.text = "";
      }
      
      public override void UpdateSkillCooldownText(ISkillVisual skillVisual)
      {
         skillVisual.CooldownText.text = "";
      }

      #endregion
   }
}
