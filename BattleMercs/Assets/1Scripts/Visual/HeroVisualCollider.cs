using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class HeroVisualCollider : MonoBehaviour, IHeroVisualCollider
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
          //TEMP
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.HeroLogicReference = HeroVisual.HeroLogicReference;
          
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewFrame();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewArmorText();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewAttackText();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewClassText();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewNameText();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewHealthText();
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.SetPreviewHeroComponents.UpdateHeroPreviewGameObjectName();
          
          //TEMP
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.Canvas.enabled = true;
          

      }
      
      private void OnMouseUp()
      {
      
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.Canvas.enabled = false;
         
      }

      #endregion
   }
}
