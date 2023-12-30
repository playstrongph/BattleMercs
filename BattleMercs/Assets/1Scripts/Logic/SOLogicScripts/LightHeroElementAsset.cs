using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "LightHeroElement", menuName = "Assets/HeroElement/LightHeroElement")]
   public class LightHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetHeroClassColor(IHeroVisual heroVisual)
      {
         heroVisual.HeroFrames.SetColorLightFrame();
      }
      
      public override void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillPreviewFrames.SetColorLightElement();
      }
      
      public override void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillElementText.text = "Light";

      }
      
      public override void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         heroPreviewVisual.HeroPreviewHero.HeroFramesVisual.SetColorLightFrame();

      }
      
      public override void UpdateSkillPanelFrameVisual(ISkillPanelVisual skillPanelVisual)
      {
         skillPanelVisual.SkillPanelFrames.SetLightFrame();
      }
      
      public override void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview)
      {
         skillPreview.SkillPreviewFrames.SetColorLightElement();

      }
        

      #endregion
   }
}
