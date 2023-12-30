using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetSkillPreviewComponents : MonoBehaviour, ISetSkillPreviewComponents
   {
      #region VARIABLES

#pragma warning disable 0649
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewVisual))] private Object skillPreviewVisual;

#pragma warning restore 0649
       
      #endregion

      #region PROPERTIES

      private ISkillPreviewVisual SkillPreviewVisual => skillPreviewVisual as ISkillPreviewVisual;

      #endregion

      #region METHODS
      
      public void UpdateSkillPreviewGameObjectName()
      {
          SkillPreviewVisual.ThisTransform.gameObject.name = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillInformation.SkillName + "SkillPreview";
      }

      public void UpdateSkillPreviewFrame()
      {
          SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillAttributes.SkillElementAsset.SetSkillPreviewClassColor(SkillPreviewVisual);
      }
      
      public void UpdateSkillPreviewGraphic()
      {
          var skillSprite = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillInformation.SkillSprite;

          SkillPreviewVisual.SkillGraphic.sprite = skillSprite;
      }
      
      public void UpdateSkillPreviewCooldownGraphic()
      {
          SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillAttributes.SkillType.SetSkillPreviewCooldownGraphic(SkillPreviewVisual);
          
      }
      
      public void UpdateSkillPreviewNameText()
      {
          var skillName = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillInformation.SkillName;

          SkillPreviewVisual.NameText.text = skillName;
      }
      
      public void UpdateSkillPreviewElementText()
      {
          SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillAttributes.SkillElementAsset.UpdateSkillPreviewElementText(SkillPreviewVisual);
      }

      public void UpdateSkillPreviewDescriptionText()
      {
          var skillDescription = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillInformation.SkillDescription;

          SkillPreviewVisual.DescriptionText.text = skillDescription;
      }
      
      public void UpdateSkillPreviewCooldownText( )
      {
          var skillCooldown = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillAttributes.BaseSkillCooldown;

          SkillPreviewVisual.CooldownText.text = skillCooldown <= 0 ? " " : skillCooldown.ToString();
      }
      
      public void UpdateSkillPreviewSpeedText( )
      {
          var skillSpeed = SkillPreviewVisual.SkillVisualReference.SkillLogicReference.SkillAttributes.BaseSkillSpeed;

          SkillPreviewVisual.SpeedText.text = skillSpeed <= 0 ? " " : skillSpeed.ToString();
      }



      #endregion
   }
}
