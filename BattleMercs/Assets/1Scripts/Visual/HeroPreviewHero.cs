using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroPreviewHero : MonoBehaviour, IHeroPreviewHero
   {
      #region VARIABLES

      [Header("Components")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFramesVisual = null;
      
      [Header("Images")]
      [SerializeField] private Image armor = null;
      [SerializeField] private Image namePlate = null;
      [SerializeField] private Image racePlate = null;

      [Header("Texts")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI nameText = null;
      [SerializeField] private TextMeshProUGUI raceText = null;

      #endregion

      #region PROPERTIES
      
      //Components
      public IHeroFramesVisual HeroFramesVisual => heroFramesVisual as IHeroFramesVisual;
      
      //Images
      public Image Armor => armor;
      public Image NamePlate => namePlate;
      public Image RacePlate => racePlate;
      
      //Texts
      public TextMeshProUGUI AttackText => attackText;
      public TextMeshProUGUI HealthText => healthText;
      public TextMeshProUGUI NameText => nameText;
      public TextMeshProUGUI RaceText => raceText;


      #endregion

      #region METHODS



      #endregion
   }
}
