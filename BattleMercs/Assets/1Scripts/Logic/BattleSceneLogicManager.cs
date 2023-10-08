﻿using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class BattleSceneLogicManager : MonoBehaviour, IBattleSceneLogicManager
   {
      #region VARIABLES
#pragma warning disable 0649 // Disable "Field is never assigned to..." warning
   
      [Header("Prefabs")]
      [SerializeField] private GameObject prefabBattleSceneManagerVisual;
      
      [Header("SO Assets")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneSettingsAsset))] private Object battleSettings;

      [Header("Runtime References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))]private Object battleSceneManagerVisual;
      
      [Header("Children Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllPlayersLogic))] private Object playersLogic;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllHeroesLogic))] private Object allHeroesLogic;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllSkillsLogic))] private Object allSkillsLogic;
      
      [Header("Attached Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeBattleSceneManagerVisual))] private Object initializeBattleSceneManagerVisual;
      
      
      

#pragma warning restore 0649 // Restore warnings
      #endregion

      #region PROPERTIES

      public GameObject PrefabBattleSceneManagerVisual => prefabBattleSceneManagerVisual;
      
      public IBattleSceneSettingsAsset BattleSettings
      {
         get => battleSettings as IBattleSceneSettingsAsset;
         set => battleSettings = value as Object;
      }
      

      public IBattleSceneManagerVisual BattleSceneManagerVisual
      {
         get => battleSceneManagerVisual as IBattleSceneManagerVisual;
         set => battleSceneManagerVisual = value as Object;
      }
      

      //Components
      public IAllPlayersLogic AllPlayersLogic => playersLogic as IAllPlayersLogic;
      public IAllHeroesLogic AllHeroesLogic => allHeroesLogic as IAllHeroesLogic;
      public IAllSkillsLogic AllSkillsLogic => allSkillsLogic as IAllSkillsLogic;
      private IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual => initializeBattleSceneManagerVisual as IInitializeBattleSceneManagerVisual;

      #endregion

      #region METHODS
      private void Start()
      {
         //TODO: In the future, Network instantiate
         InitializeBattleSceneManagerVisual.StartActions();
      }

      



      #endregion
   }
}
