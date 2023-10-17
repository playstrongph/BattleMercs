using System.Collections.Generic;
using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class PlayerVisual : MonoBehaviour, IPlayerVisual
   {
      #region VARIABLES
#pragma warning disable 0649
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private List<Object> heroVisualsList = new List<Object>();

      [Header("Set In Runtime")] [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object playerLogicReference;
#pragma warning restore 0649
      #endregion

      #region PROPERTIES
      
      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;
      
      public List<IHeroVisual> HeroVisualsList
      {
         get
         {
            var newList = new List<IHeroVisual>();
            foreach (var heroVisual in heroVisualsList)
            {
               newList.Add(heroVisual as IHeroVisual);
            }
            return newList;
         }
      }

      public IPlayerLogic PlayerLogicReference
      {
         get => playerLogicReference as IPlayerLogic;
         set => playerLogicReference = value as Object;
      }


      #endregion

      #region METHODS



      #endregion
   }
}
