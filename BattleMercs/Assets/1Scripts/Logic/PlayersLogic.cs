using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class PlayersLogic : MonoBehaviour
   {
      #region VARIABLES


      [SerializeField] private List<PlayersStruct> allPlayers = new List<PlayersStruct>();

      public List<PlayersStruct> AllPlayers => allPlayers;

      #endregion
        
      #region PROPERTIES

      #endregion
      
      #region STRUCTS


      [Serializable]
      public struct PlayersStruct
      {
         #region STRUCTVARIABLES

         [SerializeField] private string playerName;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerNumberAsset))] private Object playerIDNumber;
         [SerializeField] private int soulsCount;
         
         [Header("SET IN RUNTIME")]
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object currentEnemyPlayer;
         
         
         

         #endregion

         #region STRUCTPROPERTIES

         public string PlayerName
         {
            get => playerName;
            private set => playerName = value;
         }
         
         public IPlayerNumberAsset PlayerIDNumber
         {
            get => playerIDNumber as IPlayerNumberAsset;
            set => playerIDNumber = value as Object;
         }

         public IHeroLogic CurrentEnemyPlayer
         {
            get => currentEnemyPlayer as IHeroLogic;
            set => currentEnemyPlayer = value as Object;
         }

         public int SoulsCount
         {
            get => soulsCount;
            set => soulsCount = value;
         }



         #endregion
      }

      #endregion
        
      #region METHODS

      private void Awake()
      {
         TestPrint();
      }

      private void TestPrint()
      {
         Debug.Log("Player Element 1" +AllPlayers[0].PlayerName);
         Debug.Log("Player Element 1" +AllPlayers[1].PlayerName);
         Debug.Log("End");
      }


      #endregion
   }
}
