using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using Object = UnityEngine.Object;


namespace _1Scripts.Logic
{
   public class AllHeroesLogic : MonoBehaviour, IAllHeroesLogic
   {

      #region VARIABLES
#pragma warning disable 0649
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;

      [SerializeField] private List<GameObject> allHeroes = new List<GameObject>();
      
      

#pragma warning restore 0649

      #endregion
      
      #region PROPERTIES

      public List<IHeroLogic> AllHeroes
      {
         get
         {
            var newList = new List<IHeroLogic>();
            foreach (var hero in allHeroes)
            {
               newList.Add(hero.GetComponent<IHeroLogic>());
            }
            return newList;
         }
      }
      public IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;

      public Transform Transform => this.transform;

      #endregion

      #region METHODS

      public void AddToAllHeroesList(GameObject heroLogicGameObject)
      {
         allHeroes.Add(heroLogicGameObject);
      }



      #endregion
   }
}
