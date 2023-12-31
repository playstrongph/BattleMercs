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
          
          //Select the current enemy player for the enemy player pool
          yield return StartCoroutine(SelectEnemyPlayer());
          
          //Load Ally Player Visuals
          yield return StartCoroutine(LoadMainPlayerHeroesVisual());

          //Load Enemy Player Visuals
          yield return StartCoroutine(LoadSelectedEnemyHeroesVisual());
          
          //TEST
          yield return StartCoroutine(StartNextHeroTurn());

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
    
      private IEnumerator SelectEnemyPlayer()
      {
          LogicManagerReference.SelectEnemyPlayer.SelectNextPlayer();
          yield return null;
      }
    

      private IEnumerator LoadMainPlayerHeroesVisual()
      {
          var mainPlayer = LogicManagerReference.AllPlayersLogic.MainPlayer.GetComponent<IPlayerLogic>();
          
          
          
          mainPlayer.LoadPlayerHeroesVisual.LoadHeroesVisual();
          yield return null;
      }


      private IEnumerator LoadSelectedEnemyHeroesVisual()
      {
          var selectedEnemyPlayer = LogicManagerReference.AllPlayersLogic.SelectedEnemyPlayer.GetComponent<IPlayerLogic>();
          
          selectedEnemyPlayer.LoadPlayerHeroesVisual.LoadHeroesVisual();
          
          yield return null;
      }

      private IEnumerator StartNextHeroTurn()
      {
          LogicManagerReference.HeroTurnController.UpdateNextActiveHero();
          
          yield return null;
      }



      #endregion
   }
}
