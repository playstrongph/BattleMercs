using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class AllPlayersLogic : MonoBehaviour, IAllPlayersLogic
   {
      #region VARIABLES


      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;

      [SerializeField] private List<GameObject> allPlayers = new List<GameObject>();

      //Non-serialized variables
      

      #endregion
        
      #region PROPERTIES

      public IBattleSceneLogicManager BattleSceneLogicManager
      {
         get => battleSceneLogicManager as IBattleSceneLogicManager;
         private set => battleSceneLogicManager = value as Object;
      }

      public List<IPlayerLogic> AllPlayers
      {
         get
         {
            var newList = new List<IPlayerLogic>();
            foreach (var player in allPlayers)
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
         allPlayers.Add(playerLogicGameObject);
      }

      #endregion
      
      
      
      
   }
}
