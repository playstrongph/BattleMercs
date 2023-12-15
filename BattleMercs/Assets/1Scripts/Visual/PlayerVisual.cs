using System.Collections.Generic;
using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class PlayerVisual : MonoBehaviour, IPlayerVisual
   {
      #region VARIABLES
#pragma warning disable 0649
      
      [Header("Set In Runtime")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object playerLogicReference;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object selectedHeroVisual;
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private List<Object> heroVisualsList = new List<Object>();


#pragma warning restore 0649
      #endregion

      #region PROPERTIES
      
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;
      
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

      public IHeroVisual SelectedHeroVisual
      {
         get => selectedHeroVisual as IHeroVisual;
         set => selectedHeroVisual = value as Object;
      }


      #endregion

      #region METHODS



      #endregion
   }
}
