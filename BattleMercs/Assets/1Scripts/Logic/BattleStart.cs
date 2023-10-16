﻿using System.Collections;
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
          yield return StartCoroutine(InitializeBattleSceneManagerVisualCoroutine());

          yield return StartCoroutine(InitializeAllPlayersCoroutine());

          //yield return StartCoroutine(InitializeAllSkillsCoroutine());
          
          yield return null;
      }
      
      /// <summary>
      /// Load the prefab of BattleSceneManagerVisual
      /// </summary>
      /// <returns></returns>
      private IEnumerator InitializeBattleSceneManagerVisualCoroutine()
      {
          LogicManagerReference.InitializeBattleSceneManagerVisual.StartActions();
          yield return null;
      }

      private IEnumerator InitializeAllPlayersCoroutine()
      {
          LogicManagerReference.InitializeAllPlayers.LoadPlayers(LogicManagerReference);
          yield return null;
      }

      private IEnumerator InitializeAllSkillsCoroutine()
      {
          LogicManagerReference.InitializeAllSkills.LoadAllSkills(LogicManagerReference);
          yield return null;
      }





      #endregion
   }
}
