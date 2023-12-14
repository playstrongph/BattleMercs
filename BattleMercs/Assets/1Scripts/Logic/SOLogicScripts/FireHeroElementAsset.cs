using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "FireHeroElement", menuName = "Assets/HeroElement/FireHeroElement")]
   public class FireHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetHeroClassColor(IHeroVisual heroVisual)
      {
         heroVisual.HeroFrames.SetColorRedFrame();
      }
      
      public override void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillPreviewFrames.SetColorRedElement();
      }
      public override void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillElementText.text = "Fire";

      }
      
      public override void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         heroPreviewVisual.HeroPreviewHero.HeroFramesVisual.SetColorRedFrame();

      }
      
      public override void UpdateSkillPanelFrameVisual(ISkillPanelVisual skillPanelVisual)
      {
         skillPanelVisual.SkillPanelFrames.SetRedFrame();
      }
        

      #endregion
   }
}
