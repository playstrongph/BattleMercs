using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "FireHeroElement", menuName = "Assets/HeroElement/FireHeroElement")]
   public class FireHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic) 
      {
         var heroVisual = heroLogic.HeroVisualReference;
         heroVisual.HeroFrames.SetColorRedFrame();
      }
        

      #endregion
   }
}
