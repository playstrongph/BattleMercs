using _1Scripts.Logic.SOLogicScripts;
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
      
      public void UpdateSkillPreviewGameObjectName(string skillName)
      {
          SkillPreviewVisual.ThisTransform.gameObject.name = skillName + "SkillPreview";
      }

      public void UpdateSkillPreviewFrame(ISkillElementAsset skillElement)
      {
          skillElement.SetSkillPreviewClassColor(SkillPreviewVisual);
      }
      
      public void UpdateSkillPreviewGraphic(Sprite skillSprite)
      {
          SkillPreviewVisual.SkillGraphic.sprite = skillSprite;
      }
      
      public void UpdateSkillPreviewCooldownGraphic(ISkillTypeAsset skillType)
      {
          skillType.SetSkillPreviewCooldownGraphic(SkillPreviewVisual);
      }
      
      public void UpdateSkillPreviewNameText(string skillName)
      {
          SkillPreviewVisual.NameText.text = skillName;
      }
      
      public void UpdateSkillPreviewElementText(ISkillElementAsset skillElement)
      {
          skillElement.UpdateSkillPreviewElementText(SkillPreviewVisual);
      }

      public void UpdateSkillPreviewDescriptionText(string skillDescription)
      {
          SkillPreviewVisual.DescriptionText.text = skillDescription;
      }
      
      public void UpdateSkillPreviewCooldownText(int baseSkillCooldown )
      {
          SkillPreviewVisual.CooldownText.text = baseSkillCooldown <= 0 ? " " : baseSkillCooldown.ToString();
      }
      
      public void UpdateSkillPreviewSpeedText(int baseSkillSpeed )
      {
          SkillPreviewVisual.SpeedText.text = baseSkillSpeed <= 0 ? " " : baseSkillSpeed.ToString();
      }



      #endregion
   }
}
