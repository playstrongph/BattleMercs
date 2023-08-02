using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroPreviewSkill : MonoBehaviour, IHeroPreviewSkill
   {
      #region VARIABLES

      [Header("Components")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(SkillPreviewFrames))] private Object skillPreviewFrames = null;

      [Header("Images")] 
      [SerializeField] private Image skillPreviewGraphic = null;
      [SerializeField] private Image cooldownGraphic = null;
      [SerializeField] private Image speedGraphic = null;

      [Header("Text")] 
      [SerializeField] private TextMeshProUGUI cooldownText = null;
      [SerializeField] private TextMeshProUGUI speedText = null;
      [SerializeField] private TextMeshProUGUI skillNameText = null;
      [SerializeField] private TextMeshProUGUI skillElementText = null;
      [SerializeField] private TextMeshProUGUI skillDescriptionText = null;
      
      #endregion

      #region PROPERTIES
      
      //Components
      private ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;
      
      //Images
      public Image SkillPreviewGraphic => skillPreviewGraphic;
      public Image CooldownGraphic => cooldownGraphic;
      public Image SpeedGraphic => speedGraphic;
      
      //Text
      public TextMeshProUGUI CooldownText => cooldownText;
      public TextMeshProUGUI SpeedText => speedText;
      public TextMeshProUGUI SkillNameText => skillNameText;
      public TextMeshProUGUI SkillElementText => skillElementText;
      public TextMeshProUGUI SkillDescriptionText => skillDescriptionText;

      #endregion

      #region METHODS



      #endregion
   }
}
