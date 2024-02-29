using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetSkillVisualComponent : MonoBehaviour, ISetSkillVisualComponent
   {
      #region VARIABLES
      #pragma warning disable 0649
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisualReference;

      
      #pragma warning restore 0649
      #endregion

      #region PROPERTIES

      private ISkillVisual SkillVisualReference => skillVisualReference as ISkillVisual;

      #endregion

      #region METHODS
      
      /// <summary>
      /// Checks skill type and skill readiness before updating the skill readiness visual
      /// </summary>
      public void UpdateSkillReadinessVisual(ISkillTypeAsset skillType)
      {
         //Call SkillType UpdateSkillReadinessVisual
         skillType.UpdateSkillReadinessVisual(SkillVisualReference);
      }

      public void UpdateSkillGraphic(Sprite skillGraphic)
      {
         //Just update all for simplification
         SkillVisualReference.SkillReadyGraphic.sprite = skillGraphic;
         SkillVisualReference.SkillNotReadyGraphic.sprite = skillGraphic;
         SkillVisualReference.PassiveSkillGraphic.sprite = skillGraphic;
      }

      public void UpdateSkillSpeedText(ISkillTypeAsset skillType, int skillSpeedValue)
      {
         skillType.UpdateSkillSpeedText(SkillVisualReference, skillSpeedValue);
      }
      
      public void UpdateSkillCooldownText(ISkillTypeAsset skillType, int skillCooldown)
      {
         skillType.UpdateSkillCooldownText(SkillVisualReference,skillCooldown);
      }


      #endregion
   }
}
