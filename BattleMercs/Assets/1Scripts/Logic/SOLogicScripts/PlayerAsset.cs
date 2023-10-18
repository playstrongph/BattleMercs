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
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private List<Object> heroes = new List<Object>();


      #pragma warning restore 0649

      #endregion

      #region PROPERTIES

      public string PlayerName => playerName;
      public int SoulsCount => soulsCount;
      public List<IHeroAsset> Heroes
      {
         get
         {
            var newList = new List<IHeroAsset>();
            foreach (var hero in heroes)
            {
               newList.Add(hero as IHeroAsset);
            }
            return newList;
         }
      }

      #endregion

      #region METHODS

      public void AddToHeroesList(IHeroAsset heroAsset)
      {
         heroes.Add(heroAsset as Object);
      }


      #endregion
   }
}
