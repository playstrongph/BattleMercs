using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class HeroVisualInputAction : MonoBehaviour, IHeroVisualInputAction
   {
      #region VARIABLES
#pragma warning disable 0649
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;  
      
      
#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES

      public IHeroVisual HeroVisual => heroVisual as IHeroVisual;

      

      #endregion
        
      #region METHODS

      private void OnMouseDown()
      {
          //Show Hero Preview
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.ShowHeroPreviewVisual(HeroVisual);
          
          //Show Skills Panel for Main Player heroes only
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroSkillsVisual.ShowMainPlayerHeroSkillsPanelVisual(HeroVisual.HeroLogicReference);
          
          //Select Hero Visual for Main Player heroes only
          HeroVisual.SelectHeroVisual.UpdateMainPlayerSelectedHeroVisual();
      }
      
      private void OnMouseUp()
      {
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.HideHeroPreviewVisual();
      }

      #endregion
   }
}
