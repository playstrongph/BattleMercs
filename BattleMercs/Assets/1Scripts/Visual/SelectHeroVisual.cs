using UnityEngine;

namespace _1Scripts.Visual
{
   public class SelectHeroVisual : MonoBehaviour
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;

      [SerializeField] private Vector3 newScale = new Vector3(1.5f, 1.5f, 1f);

#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES
      
      private IHeroVisual HeroVisual => heroVisual as IHeroVisual;
        

      #endregion
        
      #region METHODS

      public void ScaleUpHero()
      {
        
      }

      #endregion
   }
}
