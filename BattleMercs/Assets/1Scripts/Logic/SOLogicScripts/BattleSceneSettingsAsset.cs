using System.Collections.Generic;
using UnityEngine;


namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneSettings/NewBattleSceneSettings")]
   public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
   {
      #region VARIABLES
#pragma warning disable 0649
      
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private Object mainPlayer;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private List<Object> allEnemyPlayers = new List<Object>();

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
      public GameObject PlayerLogicPrefab => playerLogicPrefab;
      public GameObject HeroLogicPrefab => heroLogicPrefab;
      public GameObject SkillLogicPrefab => skillLogicPrefab;
      


      //TODO:  Anomalies, game board design, power-ups, and other general combat stuff



      #endregion

      #region METHODS



      #endregion
   }
}
