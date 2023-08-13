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


      [SerializeField] private List<PlayerElements> playerElements = new List<PlayerElements>();

      #endregion
        
      #region PROPERTIES

      #endregion
      
      #region STRUCTS


      [Serializable]
      public struct PlayerElements
      {
         [SerializeField] private string playerElementName;
         [SerializeField] private List<PlayerInformation> playerInformation;
      }

      [Serializable]
      public struct PlayerInformation
      {
         [SerializeField] private string playerName;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerNumberAsset))] private Object playerIDNumber;

         public IPlayerNumberAsset PlayerIDNumber
         {
            get => playerIDNumber as IPlayerNumberAsset;
            set => playerIDNumber = value as Object;
         }
      }
      
      

      #endregion
        
      #region METHODS

    

      #endregion
   }
}
