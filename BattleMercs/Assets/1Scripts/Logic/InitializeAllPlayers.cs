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
          
         


      }


      #endregion

      #region METHODS



      #endregion
   }
}
