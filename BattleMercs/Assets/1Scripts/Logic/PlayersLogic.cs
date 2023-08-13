using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class PlayersLogic : MonoBehaviour
   {
     
      
      #region VARIABLES


      [SerializeField] private List<PlayerElements> playerElements = new List<PlayerElements>();

      public List<PlayerElements> PlayerElementsList => playerElements;

      #endregion
        
      #region PROPERTIES

      #endregion
      
      #region STRUCTS


      [Serializable]
      public struct PlayerElements
      {
         [SerializeField] private string playerElementName;
         [SerializeField] private List<PlayerInformation> playerInformation;

         public string PlayerElementsName
         {
            get => playerElementName;
            private set => playerElementName = value;
         }

         public List<PlayerInformation> PlayerInformation
         {
            get => playerInformation;

            set => playerInformation = value;
         }

      }

      [Serializable]
      public struct PlayerInformation
      {
         [SerializeField] private string playerName;

         public string PlayerName
         {
            get => playerName;
            private set => playerName = value;
         }

            [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerNumberAsset))] private Object playerIDNumber;

         public IPlayerNumberAsset PlayerIDNumber
         {
            get => playerIDNumber as IPlayerNumberAsset;
            set => playerIDNumber = value as Object;
         }
      }
      
      

      #endregion
        
      #region METHODS

      private void Awake()
      {
         TestPrint();
      }

      private void TestPrint()
      {
         Debug.Log("Player Element 1" +PlayerElementsList[0].PlayerElementsName);
         Debug.Log("Player Element 1" +PlayerElementsList[0].PlayerInformation[0].PlayerName);
         
         Debug.Log("Player Element 1" +PlayerElementsList[1].PlayerElementsName);
         Debug.Log("Player Element 1" +PlayerElementsList[1].PlayerInformation[1].PlayerName);

         Debug.Log("End");
      }


      #endregion
   }
}
