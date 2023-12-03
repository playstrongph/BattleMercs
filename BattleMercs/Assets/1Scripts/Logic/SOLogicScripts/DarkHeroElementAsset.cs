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
      
      
        

      #endregion
   }
}
