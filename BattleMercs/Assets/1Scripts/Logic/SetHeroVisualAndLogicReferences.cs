using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class SetHeroVisualAndLogicReferences : MonoBehaviour, ISetHeroVisualAndLogicReferences
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public void SetReferences(IHeroLogic heroLogic, IHeroVisual heroVisual)
      {
          heroLogic.HeroVisualReference = heroVisual;
          heroVisual.HeroLogicReference = heroLogic;

      }
        

      #endregion
   }
}
