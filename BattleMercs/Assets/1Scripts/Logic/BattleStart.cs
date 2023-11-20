﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class BattleStart : MonoBehaviour, IBattleStart
   {
      #region VARIABLES
#pragma warning disable 0649
     
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object logicManagerReference;
        
#pragma warning restore 0649
       
       #endregion
        
      #region PROPERTIES
      
      private IBattleSceneLogicManager LogicManagerReference => logicManagerReference as IBattleSceneLogicManager;  

      #endregion
        
      #region METHODS

      public void StartAction()
      {
          StartCoroutine(StartActionCoroutines());
      }

      private IEnumerator StartActionCoroutines()
      {
          yield return StartCoroutine(InitializeAllPlayersHeroesAndSkillsCoroutine());
          
          //TEST
          yield return StartCoroutine(SelectEnemyPlayer());

          yield return null;
      }
      
      /// <summary>
      /// Creates the logic game objects for all players heroes and skills
      /// Also sets the references between the main player logic and visual
      /// </summary>
      /// <returns></returns>
      private IEnumerator InitializeAllPlayersHeroesAndSkillsCoroutine()
      {
          LogicManagerReference.InitializeAllPlayers.LoadPlayers(LogicManagerReference);
          yield return null;
      }
      
      
      //TEST METHODS


      #region MyRegion

      

      #endregion
      
      /// <summary>
      /// Temporary Methods - for cleanup
      /// </summary>
      /// <returns></returns>
      private IEnumerator SelectEnemyPlayer()
      {
          //TODO: Temporary Selection process
          LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer = LogicManagerReference.AllPlayersLogic.AllEnemyPlayers[0].Transform.gameObject;

          var enemiesList = new List<IPlayerLogic>(LogicManagerReference.AllPlayersLogic.AllEnemyPlayers);
          
          if(LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer != null)
              if (enemiesList.Contains(LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer
                      .GetComponent<IPlayerLogic>()))
                  enemiesList.Remove(LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer
                      .GetComponent<IPlayerLogic>());
          
          ShuffleList(enemiesList);

          LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer = enemiesList[0].Transform.gameObject;

          yield return null;
      }
      
      // Function to shuffle the list
      private void ShuffleList(List<IPlayerLogic> itemsList)
      {
          int n = itemsList.Count;
          while (n > 1)
          {
              n--;
              int k = Random.Range(0, n + 1);
              // Swap elements at positions k and n
              (itemsList[k], itemsList[n]) = (itemsList[n], itemsList[k]);
          }
      }




      #endregion
   }
}
