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
      
      


      #endregion
   }
}
