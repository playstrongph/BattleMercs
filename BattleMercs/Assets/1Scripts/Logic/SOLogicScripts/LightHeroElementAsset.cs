using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "LightHeroElement", menuName = "Assets/HeroElement/LightHeroElement")]
   public class LightHeroElementAsset : HeroElementAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic) 
      {
         var heroVisual = heroLogic.HeroVisualReference;
         heroVisual.HeroFrames.SetColorLightFrame();
      }
        

      #endregion
   }
}
