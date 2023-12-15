using _1Scripts.Logic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroVisual : MonoBehaviour, IHeroVisual
   {
      #region VARIABLES
#pragma warning disable 0649
      [Header("Graphic Components")]
      [Header("COMPONENTS")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGlowsVisual))] private Object heroGlows = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFrames = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroStatusEffectsVisual))] private Object heroStatusEffectsVisual = null;
      [SerializeField] private Canvas canvas;

      [Header("Image Components")]
      [SerializeField] private Image armorImage = null;
      [SerializeField] private Image turnOrderImage = null;
      [SerializeField] private Image heroGraphic = null;

      [Header("Text Components")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI armorText = null;
      [SerializeField] private TextMeshProUGUI turnOrderText = null;
      
      [Header("Script Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetHeroVisualComponent))] private Object setHeroVisuals;

      [Header("Runtime Set References")] 
      [Header("REFERENCES")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogicReference;

      [Header("Inspector Set References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object playerVisualReference;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISelectHeroVisual))] private Object selectHeroVisual;

#pragma warning restore 0649
          

      #endregion

      #region PROPERTIES
      
      //Graphic Components
      public IHeroGlowsVisual HeroGlows => heroGlows as IHeroGlowsVisual;
      public IHeroFramesVisual HeroFrames => heroFrames as IHeroFramesVisual;
      public IHeroStatusEffectsVisual HeroStatusEffectsVisual => heroStatusEffectsVisual as IHeroStatusEffectsVisual;
      public Canvas Canvas => canvas;
      
      //Image Components
      public Image ArmorImage => armorImage;
      public Image TurnOrderImage => turnOrderImage;

      public Image HeroGraphic { get => heroGraphic; set => heroGraphic = value; }

      //TextMeshGUI Components
      public TextMeshProUGUI AttackText { get => attackText; set => attackText = value; }
      public TextMeshProUGUI HealthText { get => healthText; set => healthText = value; }
      public TextMeshProUGUI ArmorText { get => armorText; set => armorText = value; }
      public TextMeshProUGUI TurnOrderText { get => turnOrderText; set => turnOrderText = value; }
      
      //Script Components
      public ISetHeroVisualComponent SetHeroVisualComponent { get => setHeroVisuals as ISetHeroVisualComponent; set => setHeroVisuals = value as Object; }
      
      //Runtime Set References
      public IHeroLogic HeroLogicReference { get => heroLogicReference as IHeroLogic; set => heroLogicReference = value as Object; }
      
      //Inspector Set References
      public IPlayerVisual PlayerVisualReference => playerVisualReference as IPlayerVisual;
      public ISelectHeroVisual SelectHeroVisual => selectHeroVisual as ISelectHeroVisual;

      //Others
      public Transform Transform => transform;

      #endregion

      #region METHODS

      
      /// <summary>
      /// Updates all of the hero and hero preview's visual components
      /// </summary>
      /// <param name="heroLogic"></param>
      public void UpdateAllHeroVisualComponents(IHeroLogic heroLogic)
      {
          //Set References
          //HeroLogicReference = heroLogic;
          //heroLogic.HeroVisualReference = this;
          
          //Update the heroVisual game object name
          SetHeroVisualComponent.UpdateGameObjectHeroName(heroLogic.HeroInformation.HeroName);
          
          //Update the components
          SetHeroVisualComponent.UpdateHeroGraphic(heroLogic.HeroInformation.HeroGraphic);
          
          SetHeroVisualComponent.UpdateHeroFrameColorVisual();
          
          SetHeroVisualComponent.UpdateArmorTextAndImage();
          SetHeroVisualComponent.UpdateTurnOrderText(0);
          SetHeroVisualComponent.UpdateAttackText();
          SetHeroVisualComponent.UpdateHealthText();
              
          //Show the Hero
          SetHeroVisualComponent.ShowHeroVisual();
      }

      #endregion
   }
}
