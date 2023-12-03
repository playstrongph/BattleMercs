using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class HeroVisualCollider : MonoBehaviour, IHeroVisualCollider
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))]
      private Object heroVisual;  

      #endregion
        
      #region PROPERTIES

      public IHeroVisual HeroVisual => heroVisual as IHeroVisual;   

      #endregion
        
      #region METHODS

      private void OnMouseDown()
      {
         Debug.Log("Mouse Down: " +HeroVisual.HeroLogicReference.HeroInformation.HeroName);
      }
      
      private void OnMouseUp()
      {
         Debug.Log("Mouse Up");
      }

      #endregion
   }
}
