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
        

      #endregion
   }
}
