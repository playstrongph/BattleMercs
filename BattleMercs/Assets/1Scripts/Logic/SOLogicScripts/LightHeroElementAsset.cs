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
         heroVisual.HeroFrames.SetColorGreenFrame();
      }
        

      #endregion
   }
}
