using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroPreviewHero : MonoBehaviour, IHeroPreviewHero
   {
      #region VARIABLES

      [Header("Components")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFramesVisual = null;
      
      [Header("Images")]
      [SerializeField] private Image heroGraphic = null;
      [SerializeField] private Image armor = null;
      [SerializeField] private Image namePlate = null;
      [SerializeField] private Image classPlate = null;

      [Header("Texts")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI armorText = null;
      [SerializeField] private TextMeshProUGUI nameText = null;
      [SerializeField] private TextMeshProUGUI classText = null;

      #endregion

      #region PROPERTIES
      
      //Components
      public IHeroFramesVisual HeroFramesVisual => heroFramesVisual as IHeroFramesVisual;
      
      //Images
      public Image HeroGraphic => heroGraphic;
      public Image Armor => armor;
      public Image NamePlate => namePlate;
      public Image ClassPlate => classPlate;
      
      //Texts
      public TextMeshProUGUI AttackText { get => attackText; set => attackText = value; }
      public TextMeshProUGUI HealthText { get => healthText; set => healthText = value; }
      public TextMeshProUGUI ArmorText { get => armorText; set => armorText = value; }
      public TextMeshProUGUI NameText { get => nameText; set => nameText = value; }
      public TextMeshProUGUI ClassText { get => classText; set => classText = value; }


      #endregion

      #region METHODS



      #endregion
   }
}
