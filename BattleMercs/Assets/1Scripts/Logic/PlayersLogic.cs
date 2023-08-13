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

    [SerializeField] private List<PlayerInformation> playerInformation = new List<PlayerInformation>();


      #endregion
        
      #region PROPERTIES

      public List<PlayerInformation> NewList()
      {
         return new List<PlayerInformation>();
      }



      #endregion
      
      #region STRUCTS
      
      [Serializable]
      public struct PlayerInformation
      {
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
