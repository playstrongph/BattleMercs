using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class HeroSetup : MonoBehaviour
   {
      #region VARIABLES
      
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogic;
      
#pragma warning restore 0649

      #endregion
        
      #region PROPERTIES

      private IHeroLogic HeroLogic => heroLogic as IHeroLogic;  

      #endregion
        
      #region METHODS

      public void SetReferences(IHeroVisual heroVisual)
      {
         HeroLogic.HeroVisualReference = heroVisual;
         heroVisual.HeroLogicReference = HeroLogic;
      }  
      
      
      
      
      
      

      #endregion
   }
}
