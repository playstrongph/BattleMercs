using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroVisual : MonoBehaviour, IHeroVisual
   {
      #region VARIABLES

      [Header("Graphic Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGlowsVisual))] private Object heroGlows = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFrames = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroStatusEffectsVisual))] private Object heroStatusEffectsVisual = null;

      [Header("Image Components")]
      [SerializeField] private Image armorImage = null;
      [SerializeField] private Image turnOrderImage = null;

      [Header("TextMeshGui Components")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI armorText = null;
      [SerializeField] private TextMeshProUGUI turnOrderText = null;
      
      #endregion

      #region PROPERTIES
      
      //Graphic Components
      public IHeroGlowsVisual HeroGlows => heroGlows as IHeroGlowsVisual;
      public IHeroFramesVisual HeroFrames => heroFrames as IHeroFramesVisual;
      public IHeroStatusEffectsVisual HeroStatusEffectsVisual => heroStatusEffectsVisual as IHeroStatusEffectsVisual;
      
      
      //Image Components
      public Image ArmorImage => armorImage;
      public Image TurnOrderImage => turnOrderImage;
      
      //TextMeshGUI Components
      public TextMeshProUGUI AttackText => attackText;
      public TextMeshProUGUI HealthText => healthText;
      public TextMeshProUGUI ArmorText => armorText;
      public TextMeshProUGUI TurnOrderText => turnOrderText;
      
      //Others
      public Transform Transform => transform;

      #endregion

      #region METHODS



      #endregion
   }
}
