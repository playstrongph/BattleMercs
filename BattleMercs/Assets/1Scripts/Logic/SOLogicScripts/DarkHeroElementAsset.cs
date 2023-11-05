using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "DarkHeroElement", menuName = "Assets/HeroElement/DarkHeroElement")]
   public class DarkHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic)
      {
        var heroVisual = heroLogic.HeroVisualReference;
        heroVisual.HeroFrames.SetColorDarkFame();
      }
        

      #endregion
   }
}
