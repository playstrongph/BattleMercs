using System;
using UnityEngine;
using Object = UnityEngine.Object;


namespace _1Scripts.Visual
{
   
   public class SkillVisualInputActions : MonoBehaviour, ISkillVisualInputActions
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

        

      #endregion
        
      #region PROPERTIES
      
      public ISkillVisual SkillVisual => skillVisual as ISkillVisual;

        

      #endregion
        
      #region METHODS

      private void OnMouseDown()
      {
         
      }

      #endregion
   }
}
