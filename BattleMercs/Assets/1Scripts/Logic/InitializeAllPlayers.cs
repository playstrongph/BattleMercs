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

      public void LoadPlayers(IBattleSceneLogicManager logicManager)
      {
          var allPlayerAssets = logicManager.BattleSettings.AllPlayers;
          var allPlayersLogic = logicManager.AllPlayersLogic;
          var allPlayers = allPlayersLogic.AllPlayers;

         
          allPlayersLogic.AddNewPlayers(allPlayerAssets);

          foreach (var player in allPlayerAssets)
          {
              var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;

              var newPlayer = Instantiate(playerLogicPrefab, allPlayersLogic.Transform);
              newPlayer.name = player.PlayerName;

          }
          
         


      }


      #endregion

      #region METHODS



      #endregion
   }
}
