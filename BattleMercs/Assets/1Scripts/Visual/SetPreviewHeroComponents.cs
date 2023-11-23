using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetPreviewHeroComponents : MonoBehaviour
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewVisual))] private Object heroPreviewVisual;
      
#pragma warning restore 0649


      #endregion

      #region PROPERTIES

      private IHeroPreviewVisual HeroPreviewVisual => heroPreviewVisual as IHeroPreviewVisual;

      #endregion

      #region METHODS



      #endregion
   }
}
