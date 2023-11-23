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
         heroVisual.HeroFrames.SetColorGreenFrame();
      }
        

      #endregion
   }
}
