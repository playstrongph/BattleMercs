using UnityEngine;

namespace _1Scripts.Visual
{
   public class SelectHeroVisual : MonoBehaviour, ISelectHeroVisual
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;
        
      [Header("Manual Input Fields")]
      [SerializeField] private Vector3 newScale = new Vector3(1.5f, 1.5f, 1f);

      [SerializeField] private int defaultSortingOrder = 1;

#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES
      
      private IHeroVisual HeroVisual => heroVisual as IHeroVisual;
      private int DefaultSortingOrder => defaultSortingOrder;

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
              ResetHeroScale(HeroVisual.PlayerVisualReference.SelectedHeroVisual);
              
              if (selectedHeroVisual != HeroVisual)
              {
                  //Set the new selected Hero
                  HeroVisual.PlayerVisualReference.SelectedHeroVisual = HeroVisual;
                  
                  //Zoom in to the new selected hero
                  ScaleUpHero();
              }
              else
              {
                  UnselectHeroVisual(selectedHeroVisual);
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
      /// Unselects the hero visual when clicked again
      /// </summary>
      private void UnselectHeroVisual(IHeroVisual selectedHeroVisual)
      {
          var heroSkillsVisual = HeroVisual.PlayerVisualReference.BattleSceneVisualManager.HeroSkillsVisual;
          
          //Hide Skill Panel;
          heroSkillsVisual.HideMainPlayerHeroSkillsVisual(selectedHeroVisual.HeroLogicReference);
          
          //Clicking on the currently selected hero 'unselects' that hero
          HeroVisual.PlayerVisualReference.SelectedHeroVisual = null;
      }


      /// <summary>
      /// Zoom in to selected hero visual
      /// </summary>
      private void ScaleUpHero()
      {
          //Make sure hero appears on top
          HeroVisual.Canvas.sortingOrder++;
          
          HeroVisual.Transform.localScale = newScale;
      }
        
      /// <summary>
      /// Return hero visual to its original scale
      /// </summary>
      private void ResetHeroScale(IHeroVisual previousHeroVisual)
      {
          //Restore to the default sorting order
          previousHeroVisual.Canvas.sortingOrder = DefaultSortingOrder;
          
          previousHeroVisual.Transform.localScale = new Vector3(1, 1, 1);
      }

      #endregion
   }
}
