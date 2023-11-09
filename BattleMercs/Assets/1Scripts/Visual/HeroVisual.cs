using _1Scripts.Logic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroVisual : MonoBehaviour, IHeroVisual
   {
      #region VARIABLES
#pragma warning disable 0649
      [Header("GRAPHIC COMPONENTS")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGlowsVisual))] private Object heroGlows = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFrames = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroStatusEffectsVisual))] private Object heroStatusEffectsVisual = null;

      [Header("IMAGE COMPONENTS")]
      [SerializeField] private Image armorImage = null;
      [SerializeField] private Image turnOrderImage = null;
      [SerializeField] private Image heroGraphic = null;

      [Header("TEXT COMPONENTS")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI armorText = null;
      [SerializeField] private TextMeshProUGUI turnOrderText = null;

      [Header("REFERENCES")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogicReference;

      [Header("COMPONENTS")] [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetHeroVisuals))] private Object setHeroVisuals;
      
      
#pragma warning restore 0649
          

      #endregion

      #region PROPERTIES
      
      //Graphic Components
      public IHeroGlowsVisual HeroGlows => heroGlows as IHeroGlowsVisual;
      public IHeroFramesVisual HeroFrames => heroFrames as IHeroFramesVisual;
      public IHeroStatusEffectsVisual HeroStatusEffectsVisual => heroStatusEffectsVisual as IHeroStatusEffectsVisual;
      
      
      //Image Components
      public Image ArmorImage => armorImage;
      public Image TurnOrderImage => turnOrderImage;

      public Image HeroGraphic { get => heroGraphic; set => heroGraphic = value; }

      //TextMeshGUI Components
      public TextMeshProUGUI AttackText { get => attackText; set => attackText = value; }
      public TextMeshProUGUI HealthText { get => healthText; set => healthText = value; }
      public TextMeshProUGUI ArmorText { get => armorText; set => armorText = value; }
      public TextMeshProUGUI TurnOrderText { get => turnOrderText; set => turnOrderText = value; }
      
      //References
      public IHeroLogic HeroLogicReference { get => heroLogicReference as IHeroLogic; set => heroLogicReference = value as Object; }
      
      //Components
      public ISetHeroVisuals SetHeroVisuals { get => setHeroVisuals as ISetHeroVisuals; set => setHeroVisuals = value as Object; }

      //Others
      public Transform Transform => transform;

      #endregion

      #region METHODS



      #endregion
   }
}
