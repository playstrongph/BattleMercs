using UnityEngine;

namespace _1Scripts.Visual
{
   public class BattleSceneManagerVisual : MonoBehaviour, IBattleSceneManagerVisual
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoardVisual))] private Object gameBoardVisual = null;


      #endregion

      #region PROPERTIES

      public IGameBoardVisual GameBoardVisual
      {
         get => gameBoardVisual as IGameBoardVisual;
         private set => gameBoardVisual = value as Object;
      }



      #endregion

      #region METHODS



      #endregion
   }
}
