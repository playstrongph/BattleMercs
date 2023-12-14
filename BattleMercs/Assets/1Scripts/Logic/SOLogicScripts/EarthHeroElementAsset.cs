using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "EarthHeroElement", menuName = "Assets/HeroElement/EarthHeroElement")]
   public class EarthHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetHeroClassColor(IHeroVisual heroVisual)
      {
         heroVisual.HeroFrames.SetColorGreenFrame();
      }
      
      public override void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillPreviewFrames.SetColorGreenElement();
      }
      
      public override void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillElementText.text = "Earth";

      }
      
      
      public override void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         heroPreviewVisual.HeroPreviewHero.HeroFramesVisual.SetColorGreenFrame();

      }
      
      public override void UpdateSkillPanelFrameVisual(ISkillPanelVisual skillPanelVisual)
      {
         skillPanelVisual.SkillPanelFrames.SetGreenFrame();
      }
        

      #endregion
   }
}
