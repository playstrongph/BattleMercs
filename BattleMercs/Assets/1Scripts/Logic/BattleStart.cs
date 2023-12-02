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
          
          //TEST
          yield return StartCoroutine(LoadMainPlayerHeroesVisual());

          //TEST
          yield return StartCoroutine(LoadSelectedEnemyHeroesVisual());

          yield return null;
      }
      
      /// <summary>
      /// Creates the logic game objects for all players heroes and skills
      /// Also sets the references between the main player logic and visual
      /// </summary>
      /// <returns></returns>
      private IEnumerator InitializeAllPlayersHeroesAndSkillsCoroutine()
      {
          LogicManagerReference.InitializeAllPlayerLogics.LoadPlayers(LogicManagerReference);
          yield return null;
      }

      //TEST METHODS


      #region TestMethods

      private IEnumerator LoadMainPlayerHeroesVisual()
      {
          var mainPlayer = LogicManagerReference.AllPlayersLogic.MainPlayer.GetComponent<IPlayerLogic>();
          LoadHeroesVisual(mainPlayer);
          yield return null;
      }

      private IEnumerator SelectEnemyPlayer()
      {
          LogicManagerReference.SelectEnemyPlayer.SelectNextPlayer();
          yield return null;
      }



      private IEnumerator LoadSelectedEnemyHeroesVisual()
      {
          var selectedEnemyPlayer = LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer.GetComponent<IPlayerLogic>();
          
           (selectedEnemyPlayer);
          
          yield return null;
      }

      private void LoadHeroesVisual(IPlayerLogic player)
      {
          for (int i = 0; i < player.PlayerHeroes.Count; i++)
          {
              var heroLogic = player.PlayerHeroes[i];
              var heroVisual = player.PlayerVisualReference.HeroVisualsList[i];

              heroVisual.UpdateAllHeroVisualComponents(heroLogic);
          }
      }

      #endregion




      #endregion
   }
}
