﻿using UnityEngine;

namespace _1Scripts.Visual
{
   public class SelectHeroVisual : MonoBehaviour, ISelectHeroVisual
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;

      [SerializeField] private Vector3 newScale = new Vector3(1.5f, 1.5f, 1f);

#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES
      
      private IHeroVisual HeroVisual => heroVisual as IHeroVisual;
        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Updates the hero Visual for the Main Player only
      /// </summary>
      public void UpdateMainPlayerSelectedHeroVisual()
      {
          var mainPlayerAlliance = HeroVisual.PlayerVisualReference.PlayerLogicReference.PlayerAlliance;
          
          mainPlayerAlliance.UpdateSelectedHeroVisual(this);
      }
      
      /// <summary>
      /// Select or Unselect the HeroVisual
      /// </summary>
      public void UpdateSelectedHeroVisual()
      {
          var selectedHeroVisual = HeroVisual.PlayerVisualReference.SelectedHeroVisual;
          
          //if there's a previously selected hero
          if (selectedHeroVisual != null)
          {
              //Reset the previously selected hero's scale back to normal
              ResetHeroScale(selectedHeroVisual);
              
              if (selectedHeroVisual != HeroVisual)
              {
                  //Set the new selected Hero
                  HeroVisual.PlayerVisualReference.SelectedHeroVisual = HeroVisual;
                  
                  //Zoom in to the new selected hero
                  ScaleUpHero();
              }
              else
              {
                  //Clicking on the currently selected hero 'unselects' that hero
                  HeroVisual.PlayerVisualReference.SelectedHeroVisual = null;
              }   
          }
          //If there's no previously selected hero
          else
          {
              //Set the new selected hero
              HeroVisual.PlayerVisualReference.SelectedHeroVisual = HeroVisual;
              
              //Zoom in to the new selected hero
              ScaleUpHero();
          }
      }
      
      
      /// <summary>
      /// Zoom in to selected hero visual
      /// </summary>
      private void ScaleUpHero()
      {
          HeroVisual.Transform.localScale = newScale;
      }
        
      /// <summary>
      /// Return hero visual to its original scale
      /// </summary>
      private void ResetHeroScale(IHeroVisual previousHeroVisual)
      {
          previousHeroVisual.Transform.localScale = new Vector3(1, 1, 1);
      }

      #endregion
   }
}
