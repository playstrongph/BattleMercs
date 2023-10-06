﻿using System;
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
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private List<Object> allPlayers = new List<Object>();

      

     

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
               newList.Add(player as IPlayerLogic);
            }
            return newList;
         }
      }

      #endregion
      
      #region STRUCTS


      [Serializable]
      public struct PlayerLogic : IPlayerLogic
      {
         #region STRUCTVARIABLES
         
         #pragma warning disable 0649

         [SerializeField] private string playerName;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerNumberAsset))] private Object playerIDNumber;
         [SerializeField] private int soulsCount;
            
         
         [Header("SET IN RUNTIME")]
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object currentEnemyPlayer;
         
         //Hero Lists
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> playerHeroes;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> aliveHeroes;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> deadHeroes;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> extinctHeroes;
         
         #pragma warning restore 0649
         
         

         #endregion

         #region STRUCTPROPERTIES

         public string PlayerName { get => playerName; set => playerName = value; }
         
         public IPlayerNumberAsset PlayerIDNumber { get => playerIDNumber as IPlayerNumberAsset; set => playerIDNumber = value as Object;
         }
         
         public int SoulsCount { get => soulsCount; set => soulsCount = value; }
         
         //SET IN RUNTIME

         public IHeroLogic CurrentEnemyPlayer { get => currentEnemyPlayer as IHeroLogic; set => currentEnemyPlayer = value as Object; }

         public List<IHeroLogic> PlayerHeroes
         {
            get
            {
               var newList = new List<IHeroLogic>();
               foreach (var hero in playerHeroes)
               {
                  newList.Add(hero as IHeroLogic);
               }
               return newList;
            }
         }
         public List<IHeroLogic> AliveHeroes
         {
            get
            {
               var newList = new List<IHeroLogic>();
               foreach (var hero in aliveHeroes)
               {
                  newList.Add(hero as IHeroLogic);
               }
               return newList;
            }
         }
         public List<IHeroLogic> DeadHeroes
         {
            get
            {
               var newList = new List<IHeroLogic>();
               foreach (var hero in deadHeroes)
               {
                  newList.Add(hero as IHeroLogic);
               }
               return newList;
            }
         }
         public List<IHeroLogic> ExtinctHeroes
         {
            get
            {
               var newList = new List<IHeroLogic>();
               foreach (var hero in extinctHeroes)
               {
                  newList.Add(hero as IHeroLogic);
               }
               return newList;
            }
         }

         #endregion
      }

      #endregion
        
      #region METHODS

      
      


      #endregion
   }
}
