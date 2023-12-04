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
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.ShowHeroPreviewVisual(HeroVisual);
      }
      
      private void OnMouseUp()
      {
          HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroPreviewVisual.HideHeroPreviewVisual();
      }

      #endregion
   }
}
