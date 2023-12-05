using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "IceHeroElement", menuName = "Assets/HeroElement/IceHeroElement")]
   public class IceHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillPreviewFrames.SetColorBlueElement();
      }
      
      public override void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         heroPreviewSkill.SkillElementText.text = "Ice";

      }
      
      public override void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         heroPreviewVisual.HeroPreviewHero.HeroFramesVisual.SetColorBlueFrame();

      }
        

      #endregion
   }
}
