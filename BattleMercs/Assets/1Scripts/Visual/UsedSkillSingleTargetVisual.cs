using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class UsedSkillSingleTargetVisual : MonoBehaviour, IUsedSkillSingleTargetVisual
   {
      #region VARIABLES
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFramesVisual = null;

      [SerializeField] private Canvas canvas = null;
      [SerializeField] private Transform thisTransform = null;
      

      [Header("Images")] 
      [SerializeField] private Image armorImage = null;
      [SerializeField] private Image namePlateImage = null;
      [SerializeField] private Image racePlateImage = null;
      [SerializeField] private Image damageGraphic = null;
      [SerializeField] private Image criticalDamageGraphic = null;

      [Header("Texts")] 
      [SerializeField] private TextMeshProUGUI attackText = null;
      [SerializeField] private TextMeshProUGUI healthText = null;
      [SerializeField] private TextMeshProUGUI armorText = null;
      [SerializeField] private TextMeshProUGUI nameText = null;
      [SerializeField] private TextMeshProUGUI raceText = null;
      [SerializeField] private TextMeshProUGUI damageText = null;
      

      #endregion
        
      #region PROPERTIES

      //Components
      public IHeroFramesVisual HeroFramesVisual => heroFramesVisual as IHeroFramesVisual;
      public Canvas Canvas => canvas;
      public Transform ThisTransform => thisTransform;
      
      //Images
      public Image ArmorImage => armorImage;
      public Image NamePlateImage => namePlateImage;
      public Image RacePlateImage => racePlateImage;
      public Image DamageGraphic => damageGraphic;
      public Image CriticalDamageGraphic => criticalDamageGraphic;
      
      //Texts
      public TextMeshProUGUI AttackText => attackText;
      public TextMeshProUGUI HealthText => healthText;
      public TextMeshProUGUI ArmorText => armorText;
      public TextMeshProUGUI NameText => nameText;
      public TextMeshProUGUI RaceText => raceText;
      public TextMeshProUGUI DamageText => damageText;


      #endregion

      #region METHODS



      #endregion
   }
}
