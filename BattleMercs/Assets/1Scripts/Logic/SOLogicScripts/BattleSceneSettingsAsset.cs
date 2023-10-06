using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneSettings/NewBattleSceneSettings")]
   public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))] private List<Object> playerTeamHeroes = new List<Object>();  

      #endregion
        
      #region PROPERTIES
      
      public List<ITeamHeroesAsset> PlayerTeamHeroes
      {
         get
         {
            var newList = new List<ITeamHeroesAsset>();
            foreach (var teamHero in playerTeamHeroes)
            {
               newList.Add(teamHero as ITeamHeroesAsset);
            }
            return newList;
         }
      }
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
