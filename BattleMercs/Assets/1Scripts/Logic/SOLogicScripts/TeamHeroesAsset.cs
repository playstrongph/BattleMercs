using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "NewTeamHeroesAsset", menuName = "Assets/TeamHeroesAsset/NewTeamHeroesAsset")]
   public class TeamHeroesAsset : ScriptableObject, ITeamHeroesAsset
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private List<Object> teamHeroes = new List<Object>();
      
      #endregion

      #region PROPERTIES

      public List<IHeroAsset> TeamHeroes
      {
         get
         {
            var newList = new List<IHeroAsset>();
            foreach (var hero in teamHeroes)
            {
               newList.Add(hero as IHeroAsset);
            }
            return newList;
         }
      }


      #endregion

      #region METHODS



      #endregion
   }
}
