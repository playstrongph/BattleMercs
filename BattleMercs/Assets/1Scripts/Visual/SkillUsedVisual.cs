using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillUsedVisual : MonoBehaviour, ISkillUsedVisual
   {
      #region VARIABLES

      //TODO: Inspector Reference for UsedSkillPreviewVisual

      [Header("Components")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFramesVisual))] private Object heroFramesVisual = null;
      [SerializeField] private Canvas canvas = null;
      
      [Header("Images")] 
      [SerializeField] private Image skillGraphic = null;
      [SerializeField] private Image cooldownImage = null;
      [SerializeField] private Image speedImage = null;
      [SerializeField] private Image arrowGlowImage = null;
      [SerializeField] private Image arrowImage = null;
      [SerializeField] private Image heroImage = null;

      [Header("Texts")] 
      [SerializeField] private TextMeshProUGUI nameText = null;
      [SerializeField] private TextMeshProUGUI elementText = null;
      [SerializeField] private TextMeshProUGUI descriptionText = null;
      [SerializeField] private TextMeshProUGUI cooldownText = null;
      [SerializeField] private TextMeshProUGUI speedText = null;

      #endregion

      #region PROPERTIES

      //Components
      public ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;
      public IHeroFramesVisual HeroFramesVisual => heroFramesVisual as IHeroFramesVisual;
      public Canvas Canvas => canvas;
      
      //Images
      public Image SkillGraphic => skillGraphic;
      public Image CooldownImage => cooldownImage;
      public Image SpeedImage => speedImage;
      public Image ArrowGlowImage => arrowGlowImage;
      public Image ArrowImage => arrowImage;
      public Image HeroImage => heroImage;
      
      //Texts
      public TextMeshProUGUI NameText => nameText;
      public TextMeshProUGUI ElementText => elementText;
      public TextMeshProUGUI DescriptionText => descriptionText;
      public TextMeshProUGUI CooldownText => cooldownText;
      public TextMeshProUGUI SpeedText => speedText;

      #endregion

      #region METHODS



      #endregion
   }
}
