﻿using System.Collections.Generic;
using System.Text;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;


namespace _1Scripts.Logic
{
   public class InitializeAllPlayers : MonoBehaviour, IInitializeAllPlayers
   {
      #region VARIABLES
#pragma warning disable 0649

#pragma warning restore 0649

      #endregion

      #region PROPERTIES


      #endregion

      #region METHODS
      
      public void LoadPlayers(IBattleSceneLogicManager logicManager)
      {
          LoadMainPlayer(logicManager);
          
          LoadAllEnemyPlayers(logicManager);
      }

      private void LoadMainPlayer(IBattleSceneLogicManager logicManager)
      {
          var mainPlayerAsset = logicManager.BattleSettings.MainPlayer;
          var allPlayersLogic = logicManager.AllPlayersLogic;
          var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;

          
          //var playerHeroes = mainPlayerAsset.Heroes;
          var newPlayer = Instantiate(playerLogicPrefab, logicManager.Transform);
          newPlayer.name = mainPlayerAsset.PlayerName;
              
          var newPlayerLogic = newPlayer.GetComponent<IPlayerLogic>();

          //Set player name
          newPlayerLogic.PlayerName = mainPlayerAsset.PlayerName;
          //Set unique player ID Number
          newPlayerLogic.PlayerIDNumber = logicManager.UniqueIDGenerator.GenerateUniqueID();
          //Set SoulsCount
          newPlayerLogic.SoulsCount = mainPlayerAsset.SoulsCount;
              
          //Player Heroes Reference
          allPlayersLogic.AddToAllPlayersList(newPlayer);

          //Create The Heroes here so you can set the reference
          logicManager.InitializeAllHeroes.LoadHeroes(logicManager,newPlayerLogic,mainPlayerAsset.Heroes);
      }

      private void LoadAllEnemyPlayers(IBattleSceneLogicManager logicManager)
      {
          var allEnemyPlayerAssets = logicManager.BattleSettings.AllEnemyPlayers;
          var allPlayersLogic = logicManager.AllPlayersLogic;
          var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;

          foreach (var enemyPlayerAsset in allEnemyPlayerAssets)
          {
              var playerHeroes = enemyPlayerAsset.Heroes;
              var newPlayer = Instantiate(playerLogicPrefab, logicManager.Transform);
              newPlayer.name = enemyPlayerAsset.PlayerName;
              
              var newPlayerLogic = newPlayer.GetComponent<IPlayerLogic>();

              //Set player name
              newPlayerLogic.PlayerName = enemyPlayerAsset.PlayerName;
              //Set unique player ID Number
              newPlayerLogic.PlayerIDNumber = logicManager.UniqueIDGenerator.GenerateUniqueID();
              //Set SoulsCount
              newPlayerLogic.SoulsCount = enemyPlayerAsset.SoulsCount;
              
              //Player Heroes Reference
              allPlayersLogic.AddToAllPlayersList(newPlayer);

              //Create The Heroes here so you can set the reference
              logicManager.InitializeAllHeroes.LoadHeroes(logicManager,newPlayerLogic,playerHeroes);
          }
      }




      #endregion
   }
}
