using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillPreviewVisual : MonoBehaviour, ISkillPreviewVisual
   {
      #region VARIABLES

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleManagerVisual = null;

      [Header("Components")] 
      [SerializeField] private Canvas canvas = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;

      [Header("Images")] 
      [SerializeField] private Image skillGraphic = null;
      [SerializeField] private Image cooldownGraphic = null;
      [SerializeField] private Image speedGraphic = null;

      [Header("Texts")] 
      [SerializeField] private TextMeshProUGUI nameText = null;
      [SerializeField] private TextMeshProUGUI elementText = null;
      [SerializeField] private TextMeshProUGUI descriptionText = null;
      [SerializeField] private TextMeshProUGUI cooldownText = null;
      [SerializeField] private TextMeshProUGUI speedText = null;

      #endregion

      #region PROPERTIES
      
      //Inspector References
      private IBattleSceneManagerVisual BattleSceneManagerVisual => battleManagerVisual as IBattleSceneManagerVisual;
      
      //Components
      public Canvas Canvas => canvas;
      public ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;
      
      //Images
      public Image SkillGraphic => skillGraphic;
      public Image CooldownGraphic => cooldownGraphic;
      public Image SpeedGraphic => speedGraphic;
      
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
