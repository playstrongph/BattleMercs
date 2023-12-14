using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class HeroSkillsVisual : MonoBehaviour, IHeroSkillsVisual
   {
      #region VARIABLES
      
      #pragma warning disable 0649

      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object threeSkillPanelVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object fourSkillPanelVisual = null;
      [SerializeField] private Canvas canvas = null;

      [Header("Runtime References")] [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogicReference;

      [Header("Inspector References")] [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;
      
#pragma warning restore 0649

      #endregion

      #region PROPERTIES
      private Canvas Canvas => canvas;

      private IHeroLogic HeroLogicReference
      {
         get => heroLogicReference as IHeroLogic;
         set => heroLogicReference = value as Object;
      }
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;

      public ISkillPanelVisual ThreeSkillPanelVisual => threeSkillPanelVisual as ISkillPanelVisual;
      
      public ISkillPanelVisual FourSkillPanelVisual => fourSkillPanelVisual as ISkillPanelVisual;


      #endregion

      #region METHODS
      
      /// <summary>
      /// Display hero skills panel only for the main player
      /// </summary>
      /// <param name="referenceHeroLogic"></param>
      public void ShowMainPlayerHeroSkillsVisual(IHeroLogic referenceHeroLogic)
      {
         
         var playerAlliance = referenceHeroLogic.PlayerReference.PlayerAlliance;
         
         //Check if the hero is in the team of the main player
         referenceHeroLogic.PlayerReference.PlayerAlliance.DisplayHeroSkills(this, referenceHeroLogic);
         
         
      }
      
      public void HideMainPlayerHeroSkillsVisual(IHeroLogic referenceHeroLogic)
      {
         Canvas.enabled = false;
      }
      
      
      /// <summary>
      /// Loads the hero skills visual information and displays it
      /// </summary>
      /// <param name="referenceHeroLogic"></param>
      public void ShowHeroSkillsVisual(IHeroLogic referenceHeroLogic)
      {
         //TODO
         //Set HeroLogic Reference
         HeroLogicReference = referenceHeroLogic;
         
         //Select four or three panelvisual
         
         

         
         //TODO: Enable Canvas
         Canvas.enabled = true;
      }
      
      
      
      
      
      


      #endregion
   }
}
