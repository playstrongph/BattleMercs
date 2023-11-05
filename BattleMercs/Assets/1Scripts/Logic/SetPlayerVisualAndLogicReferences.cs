using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class SetPlayerVisualAndLogicReferences : MonoBehaviour, ISetPlayerVisualAndLogicReferences
   {
      #region VARIABLES
#pragma warning disable 0649
       
      


#pragma warning restore 0649
      #endregion

      #region PROPERTIES
      
     


      #endregion

      #region METHODS

      public void SetReferences(IPlayerLogic playerLogic, IPlayerVisual playerVisual)
      {
          playerLogic.PlayerVisualReference = playerVisual;
          playerVisual.PlayerLogicReference = playerLogic;
      }



      #endregion
   }
}
