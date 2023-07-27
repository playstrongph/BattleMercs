using UnityEngine;

namespace _1Scripts.Visual
{
   public class BattleSceneManagerVisual : MonoBehaviour, IBattleSceneManagerVisual
   {
      #region VARIABLES
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoardVisual))] private Object gameBoardVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object mainPlayerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object enemyPlayerVisual = null;


      #endregion

      #region PROPERTIES
      
      public IPlayerVisual MainPlayerVisual => mainPlayerVisual as IPlayerVisual;
      public IPlayerVisual EnemyPlayerVisual => enemyPlayerVisual as IPlayerVisual;

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
