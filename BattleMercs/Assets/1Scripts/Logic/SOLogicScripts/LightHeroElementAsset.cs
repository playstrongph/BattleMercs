using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "LightHeroElement", menuName = "Assets/HeroElement/LightHeroElement")]
   public class LightHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
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
        

      #endregion
   }
}
