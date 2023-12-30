using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "DarkHeroElement", menuName = "Assets/HeroElement/DarkHeroElement")]
   public class DarkHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetHeroClassColor(IHeroVisual heroVisual)
      {
         heroVisual.HeroFrames.SetColorDarkFame();
      }
      
      
      public override void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         heroPreviewVisual.HeroPreviewHero.HeroFramesVisual.SetColorDarkFame();

      }
      
      public override void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillPreviewFrames.SetColorDarkElement();
      }
      
      public override void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillElementText.text = "Dark";

      }
      
      public override void UpdateSkillPanelFrameVisual(ISkillPanelVisual skillPanelVisual)
      {
         skillPanelVisual.SkillPanelFrames.SetDarkFrame();
      }
      
      public override void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview)
      {
         skillPreview.SkillPreviewFrames.SetColorDarkElement();

      }

      
      
        

      #endregion
   }
}
