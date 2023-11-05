using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "IceHeroElement", menuName = "Assets/HeroElement/IceHeroElement")]
   public class IceHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic) 
      {
         var heroVisual = heroLogic.HeroVisualReference;
         heroVisual.HeroFrames.SetColorBlueFrame();
      }
        

      #endregion
   }
}
