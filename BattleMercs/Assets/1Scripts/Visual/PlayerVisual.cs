using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class PlayerVisual : MonoBehaviour, IPlayerVisual
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private List<Object> heroVisualsList = new List<Object>();

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


      #endregion

      #region METHODS



      #endregion
   }
}
