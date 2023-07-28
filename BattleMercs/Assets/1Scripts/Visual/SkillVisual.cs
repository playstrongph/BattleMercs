using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillVisual : MonoBehaviour, ISkillVisual
   {
      #region VARIABLES
      
      [Header("Transforms")]
      [SerializeField] private Transform skillReadyVisualTransform = null;
      [SerializeField] private Transform skillNotReadyVisualTransform = null;
      [SerializeField] private Transform passiveSkillVisualTransform = null;

      [Header("Images")]
      [SerializeField] private Image skillReadyGraphic = null;
      [SerializeField] private Image skillNotReadyGraphic = null;
      [SerializeField] private Image passiveSkillGraphic = null;
      
      [Header("Canvas")]
      [SerializeField] private Canvas skillReadyCanvas = null;
      [SerializeField] private Canvas skillNotReadyCanvas = null;
      [SerializeField] private Canvas passiveSkillCanvas = null;

      [Header("Text")] 
      [SerializeField] private TextMeshProUGUI speedText = null;
      [SerializeField] private TextMeshProUGUI cooldownText = null;

      #endregion

      #region PROPERTIES
      
      //TRANSFORMS
      public Transform SkillReadyVisualTransform => skillReadyVisualTransform;
      public Transform SkillNotReadyVisualTransform => skillNotReadyVisualTransform;
      public Transform PassiveSkillVisualTransform => passiveSkillVisualTransform;

      //IMAGES
      public Image SkillReadyGraphic => skillReadyGraphic;
      public Image SkillNotReadyGraphic => skillNotReadyGraphic;
      public Image PassiveSkillGraphic => passiveSkillGraphic;
      
      //CANVAS
      public Canvas SkillReadyCanvas => skillReadyCanvas;
      public Canvas SkillNotReadyCanvas => skillNotReadyCanvas;
      public Canvas PassiveSkillCanvas => passiveSkillCanvas;
      
      //TEXT
      public TextMeshProUGUI SpeedText => speedText;
      public TextMeshProUGUI CooldownText => cooldownText;



      #endregion

      #region METHODS



      #endregion
   }
}
