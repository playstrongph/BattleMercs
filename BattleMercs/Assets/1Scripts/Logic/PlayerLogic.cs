﻿using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class PlayerLogic : MonoBehaviour,IPlayerLogic
   {
      #region VARIABLES
      
#pragma warning disable 0649

      [Header("Player Attributes")]
      [SerializeField] private string playerName;
      [SerializeField] private string playerIDNumber;
      [SerializeField] private int soulsCount;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private Object playerAlliance;
      
      [Header("Runtime Set References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object playerVisualReference;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object currentEnemyPlayer;

      [Header("Hero Lists")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> playerHeroes;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> aliveHeroes;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> deadHeroes;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> extinctHeroes;
      
      [Header("Script Components")]
      //[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetPlayerVisualAndLogicReferences))] private Object setPlayerVisualAndLogicReferences;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ILoadPlayerHeroesVisual))] private Object loadPlayerHeroesVisual;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(InitializeAllHeroes))] private Object initializeAllHeroes;
         
#pragma warning restore 0649
        

      #endregion
        
      #region PROPERTIES
      
      //PLAYER ATTRIBUTES
      public string PlayerName { get => playerName; set => playerName = value; }
      public string PlayerIDNumber { get => playerIDNumber; set => playerIDNumber = value; }
      public int SoulsCount { get => soulsCount; set => soulsCount = value; }

      public IPlayerAllianceAsset PlayerAlliance
      {
         get => playerAlliance as IPlayerAllianceAsset;
         set => playerAlliance = value as Object;
      }

      //OTHERS
      public Transform Transform => this.transform;
               
      //RUN TIME SET REFERENCES
      public IPlayerVisual PlayerVisualReference
      {
         get => playerVisualReference as IPlayerVisual;
         set => playerVisualReference = value as Object;
      }
      public IPlayerLogic CurrentEnemyPlayer { get => currentEnemyPlayer as IPlayerLogic; set => currentEnemyPlayer = value as Object; }
      
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
      
      //SCRIPT COMPONENTS
      public IInitializeAllHeroes InitializeAllHeroes => initializeAllHeroes as IInitializeAllHeroes;
      
      public ILoadPlayerHeroesVisual LoadPlayerHeroesVisual => loadPlayerHeroesVisual as ILoadPlayerHeroesVisual;
      //public ISetPlayerVisualAndLogicReferences SetPlayerVisualAndLogicReferences => setPlayerVisualAndLogicReferences as ISetPlayerVisualAndLogicReferences;
      
               
      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Add to "object" list displayed in the Inspector
      /// </summary>
      /// <param name="heroLogic"></param>
      public void AddToPlayerHeroesList(IHeroLogic heroLogic)
      {
         playerHeroes.Add(heroLogic as Object);
      }
      
      /// <summary>
      /// Add to "object" list displayed in the Inspector
      /// </summary>
      /// <param name="heroLogic"></param>
      public void AddToAliveHeroesList(IHeroLogic heroLogic)
      {
         aliveHeroes.Add(heroLogic as Object);
      }
      
      /// <summary>
      /// Add to "object" list displayed in the Inspector
      /// </summary>
      /// <param name="heroLogic"></param>
      public void AddToDeadHeroesList(IHeroLogic heroLogic)
      {
         deadHeroes.Add(heroLogic as Object);
      }
      
      /// <summary>
      /// Add to "object" list displayed in the Inspector
      /// </summary>
      /// <param name="heroLogic"></param>
      public void AddToExtinctHeroesList(IHeroLogic heroLogic)
      {
         extinctHeroes.Add(heroLogic as Object);
      }



      #endregion
   }
}
