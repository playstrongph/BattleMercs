using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillPreviewVisual : MonoBehaviour, ISkillPreviewVisual
   {
      #region VARIABLES

      #pragma warning disable 0649
      
     
      [Header("Runtime References")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisualReference;

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleManagerVisual = null;
      

      [Header("Components")] 
      [SerializeField] private Canvas canvas = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetSkillPreviewComponents))] private Object setSkillPreviewComponents = null;

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
      
      [Header("Preview Parameters")] 
      [SerializeField] private float displayDelay = 0.5f;
      [SerializeField] private bool enablePreview = false;
      
      //Private variables
      private Coroutine _delayCoroutine;
      
      #pragma warning restore 0649

      #endregion

      #region PROPERTIES
      
      //Runtime References
      public ISkillVisual SkillVisualReference
      {
         get => skillVisualReference as ISkillVisual;
         set => skillVisualReference = value as Object;
      }

      //Inspector References
      private IBattleSceneVisualManager BattleSceneVisualManager => battleManagerVisual as IBattleSceneVisualManager;
      public ISetSkillPreviewComponents SetSkillPreviewComponents => setSkillPreviewComponents as ISetSkillPreviewComponents;
      
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

      public Transform ThisTransform => transform;

      #endregion

      #region METHODS

      public void ShowSkillPreviewVisual(ISkillVisual skillVisual)
      {
         enablePreview = true;
         
         if(_delayCoroutine != null)StopCoroutine(_delayCoroutine);

         _delayCoroutine = StartCoroutine(UpdateSkillPreviewCoroutine(skillVisual));
      }
      
      public void HideSkillPreviewVisual()
      {
         enablePreview = false;
         Canvas.enabled = false;
         
         if(_delayCoroutine != null)StopCoroutine(_delayCoroutine);
      }
      
      private IEnumerator UpdateSkillPreviewCoroutine(ISkillVisual skillVisual)
      {

         yield return new WaitForSeconds(displayDelay);

         if (enablePreview)
         {
            UpdateSkillPreviewVisualComponents(skillVisual);
            Canvas.enabled = true;
         }

         _delayCoroutine = null;
      }

      private void UpdateSkillPreviewVisualComponents(ISkillVisual skillVisual)
      {
         //SetReference
         SkillVisualReference = skillVisual;
         
         //Skill Information
         var previewGameObjectName = skillVisual.SkillLogicReference.SkillInformation.SkillName;
         
         //Update the Skill preview Components
         SetSkillPreviewComponents.UpdateSkillPreviewGameObjectName(previewGameObjectName);
         SetSkillPreviewComponents.UpdateSkillPreviewFrame();
         SetSkillPreviewComponents.UpdateSkillPreviewGraphic();
         SetSkillPreviewComponents.UpdateSkillPreviewCooldownGraphic();
         SetSkillPreviewComponents.UpdateSkillPreviewNameText();
         SetSkillPreviewComponents.UpdateSkillPreviewElementText();
         SetSkillPreviewComponents.UpdateSkillPreviewDescriptionText();
         SetSkillPreviewComponents.UpdateSkillPreviewCooldownText();
         SetSkillPreviewComponents.UpdateSkillPreviewSpeedText();
         
      }

      #endregion
   }
}
