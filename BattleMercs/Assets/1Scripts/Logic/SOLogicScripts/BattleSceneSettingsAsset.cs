using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneSettings/NewBattleSceneSettings")]
   public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
   {
      #region VARIABLES
#pragma warning disable 0649

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private List<Object> allPlayers = new List<Object>();

      [Header("PREFABS")]
      [SerializeField] private GameObject playerLogicPrefab;
      [SerializeField] private GameObject heroLogicPrefab;
      
#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES
      
      public List<IPlayerAsset> AllPlayers
      {
         get
         {
            var newList = new List<IPlayerAsset>();
            foreach (var player in allPlayers)
            {
               newList.Add(player as IPlayerAsset);
            }
            return newList;
         }
      }
      public GameObject PlayerLogicPrefab => playerLogicPrefab;
      public GameObject HeroLogicPrefab => heroLogicPrefab;
      


      //TODO:  Anomalies, game board design, power-ups, and other general combat stuff



      #endregion

      #region METHODS



      #endregion
   }
}
