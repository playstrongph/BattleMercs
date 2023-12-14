using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetSkillVisualComponent : MonoBehaviour
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
      public void UpdateSkillReadinessVisual()
      {
         var skillType = SkillVisualReference.SkillLogicReference.SkillAttributes.SkillType;

         //Call SkillType UpdateSkillReadinessVisual
         skillType.UpdateSkillReadinessVisual(SkillVisualReference);
      }


      #endregion
   }
}
