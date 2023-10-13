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


          foreach (var playerAsset in allPlayerAssets)
          {
              var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;
              var newPlayer = Instantiate(playerLogicPrefab, allPlayersLogic.Transform);
              var newPlayerLogic = newPlayer.GetComponent<IPlayerLogic>();

              newPlayer.name = playerAsset.PlayerName;
              
              //Load player asset por
              newPlayerLogic.PlayerName = playerAsset.PlayerName;
              //TODO: PlayerNumber
              newPlayerLogic.PlayerIDNumber = logicManager.UniqueIDGenerator.GenerateUniqueID();
              //TODO: SoulsCount
              //TODO: Player Heroes

              allPlayersLogic.AddToAllPlayersList(newPlayer);
          }
      }

      
      
      
      #endregion
   }
}
