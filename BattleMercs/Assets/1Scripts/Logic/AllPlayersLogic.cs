using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class AllPlayersLogic : MonoBehaviour, IAllPlayersLogic
   {
      #region VARIABLES


      [Header("INSPECTOR REFERENCES")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;
      
      [SerializeField] private GameObject mainPlayer;
      
      [Header("RUNTIME REFERENCES")]
      [SerializeField] private GameObject selectedEnemyPlayer;
      
      [FormerlySerializedAs("allPlayers")] [SerializeField] private List<GameObject> allEnemyPlayers = new List<GameObject>();

     
      

      #endregion
        
      #region PROPERTIES

      public IBattleSceneLogicManager BattleSceneLogicManager
      {
         get => battleSceneLogicManager as IBattleSceneLogicManager;
         private set => battleSceneLogicManager = value as Object;
      }

      public GameObject MainPlayer { get => mainPlayer; set => mainPlayer = value; }
      
      public GameObject SelectedEnemyPlayer { get => selectedEnemyPlayer; set => selectedEnemyPlayer = value; }

      public List<IPlayerLogic> AllEnemyPlayers
      {
         get
         {
            var newList = new List<IPlayerLogic>();
            foreach (var player in allEnemyPlayers)
            {
               newList.Add(player.GetComponent<IPlayerLogic>());
            }
            return newList;
         }
      }
      


      public Transform Transform => this.transform;

      #endregion
      
      #region METHODS


      public void AddToAllPlayersList(GameObject playerLogicGameObject)
      {
         allEnemyPlayers.Add(playerLogicGameObject);
      }

      #endregion
      
      
      
      
   }
}
