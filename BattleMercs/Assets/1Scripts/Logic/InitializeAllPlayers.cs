using System.Collections.Generic;
using System.Text;
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
          var allPlayerAssets = logicManager.BattleSettings.AllPlayers;
          var allPlayersLogic = logicManager.AllPlayersLogic;
          var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;

          foreach (var playerAsset in allPlayerAssets)
          {
              var teamHeroesAsset = playerAsset.PlayerHeroes;
              var newPlayer = Instantiate(playerLogicPrefab, allPlayersLogic.Transform);
              newPlayer.name = playerAsset.PlayerName;
              
              var newPlayerLogic = newPlayer.GetComponent<IPlayerLogic>();

              //Set player name
              newPlayerLogic.PlayerName = playerAsset.PlayerName;
              //Set unique player ID Number
              newPlayerLogic.PlayerIDNumber = logicManager.UniqueIDGenerator.GenerateUniqueID();
              //Set SoulsCount
              newPlayerLogic.SoulsCount = playerAsset.SoulsCount;
              
              //Player Heroes Reference
              allPlayersLogic.AddToAllPlayersList(newPlayer);
              
              
              
              //Create The Heroes here so you can set the reference
              logicManager.InitializeAllHeroes.LoadHeroes(logicManager,newPlayerLogic,teamHeroesAsset);
          }
      }

      
      
      
      #endregion
   }
}
