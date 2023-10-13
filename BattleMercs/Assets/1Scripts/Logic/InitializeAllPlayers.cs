using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace _1Scripts.Logic
{
   public class InitializeAllPlayers : MonoBehaviour, IInitializeAllPlayers
   {
      #region VARIABLES
#pragma warning disable 0649
       
       [SerializeField] private List<string> playerIDs = new List<string>();
      
      
#pragma warning restore 0649

      #endregion

      #region PROPERTIES

      private List<string> PlayerIDs => playerIDs;

      public void LoadPlayers(IBattleSceneLogicManager logicManager)
      {
          var allPlayerAssets = logicManager.BattleSettings.AllPlayers;
          var allPlayersLogic = logicManager.AllPlayersLogic;
          
          
          //Create unique Player ID's first
          GenerateUniquePlayerIDs(allPlayerAssets.Count);

          for (int i = 0; i < allPlayerAssets.Count; i++)
          {
              var playerLogicPrefab = logicManager.BattleSettings.PlayerLogicPrefab;
              var newPlayer = Instantiate(playerLogicPrefab, allPlayersLogic.Transform);
              var newPlayerLogic = newPlayer.GetComponent<IPlayerLogic>();

              var playerAsset = allPlayerAssets[i];
              
              newPlayer.name = playerAsset.PlayerName;
              
              //Load player asset por
              newPlayerLogic.PlayerName = playerAsset.PlayerName;
              //TODO: PlayerNumber
              newPlayerLogic.PlayerIDNumber = PlayerIDs[i];
              //TODO: SoulsCount
              //TODO: Player Heroes

              allPlayersLogic.AddToAllPlayersList(newPlayer);
          }
      }


      #endregion

      #region METHODS
      
      
      private void GenerateUniquePlayerIDs(int playerCount)
      {

          for (int j = 0; j < playerCount; j++)
          {
              // ReSharper disable once StringLiteralTypo
              string alphabetChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
              System.Random random = new System.Random();

              var idFound = false;
              
              while (!idFound)
              {
                  StringBuilder idBuilder = new StringBuilder();

                  // Generate the first three characters (ABC)
                  for (int i = 0; i < 3; i++)
                  {
                      idBuilder.Append(alphabetChars[random.Next(alphabetChars.Length)]);
                  }
              
                  // Insert a "-" after the letters
                  idBuilder.Append("-");

                  // Generate the last three digits (123)
                  for (int i = 0; i < 3; i++)
                  {
                      idBuilder.Append(random.Next(10)); // Random digit (0-9)
                  }

                  string newID = idBuilder.ToString();

                  // Check if the ID is unique
                  if (!playerIDs.Contains(newID))
                  {
                      playerIDs.Add(newID);
                      idFound = true;
                  }
                  
              }
          }

         
      }


      #endregion
   }
}
