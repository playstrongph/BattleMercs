using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneSettings/NewBattleSceneSettings")]
   public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAsset))] private List<Object> players = new List<Object>();  

      #endregion
        
      #region PROPERTIES
      
      public List<IPlayerAsset> Player
      {
         get
         {
            var newList = new List<IPlayerAsset>();
            foreach (var player in players)
            {
               newList.Add(player as IPlayerAsset);
            }
            return newList;
         }
      }
      
      //TODO:  Anomalies, game board design, power-ups, and other general combat stuff
      
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
