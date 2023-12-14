using System.Collections.Generic;
using UnityEngine;


namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneSettings/NewBattleSceneSettings")]
   public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
   {
      #region VARIABLES
#pragma warning disable 0649
      
      [Header("PLAYER ASSETS")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private Object mainPlayer;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private List<Object> allEnemyPlayers = new List<Object>();
      
      [Header("PLAYER ALLIANCE ASSETS")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private Object allyPlayer;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private Object enemyPlayer;

      [Header("PREFABS")]
      [SerializeField] private GameObject playerLogicPrefab;
      [SerializeField] private GameObject heroLogicPrefab;
      [SerializeField] private GameObject skillLogicPrefab;
#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES

      public IPlayerAsset MainPlayer => mainPlayer as IPlayerAsset;
      
      public List<IPlayerAsset> AllEnemyPlayers
      {
         get
         {
            var newList = new List<IPlayerAsset>();
            foreach (var player in allEnemyPlayers)
            {
               newList.Add(player as IPlayerAsset);
            }
            return newList;
         }
      }
      
      public IPlayerAllianceAsset AllyPlayerAlliance => allyPlayer as IPlayerAllianceAsset;
      public IPlayerAllianceAsset EnemyPlayerAlliance => enemyPlayer as IPlayerAllianceAsset;

      public GameObject PlayerLogicPrefab => playerLogicPrefab;
      public GameObject HeroLogicPrefab => heroLogicPrefab;
      public GameObject SkillLogicPrefab => skillLogicPrefab;
      
      
      


      //TODO:  Anomalies, game board design, power-ups, and other general combat stuff



      #endregion

      #region METHODS



      #endregion
   }
}
