using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "NewPlayer", menuName = "Assets/PlayerAsset/NewPlayerAsset")]
   public class PlayerAsset : ScriptableObject, IPlayerAsset
   {
      #region VARIABLES
      #pragma warning disable 0649

      [SerializeField] private string playerName;
      [SerializeField] private int soulsCount;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))] private Object playerHeroes;
       
      
      #pragma warning restore 0649

      #endregion

      #region PROPERTIES

      public string PlayerName => playerName;
      public int SoulsCount => soulsCount;
      public ITeamHeroesAsset PlayerHeroes => playerHeroes as ITeamHeroesAsset;

      #endregion

      #region METHODS
      


      #endregion
   }
}
