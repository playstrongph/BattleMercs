using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class HeroStatusEffectsVisual : MonoBehaviour, IHeroStatusEffectsVisual
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IStatusEffectVisual))]private List<Object> statusEffectsList = new List<Object>();  

      #endregion
        
      #region PROPERTIES
      
      public List<IStatusEffectVisual> StatusEffectsList
      {
         get
         {
            var newList = new List<IStatusEffectVisual>();
            foreach (var statusEffect in statusEffectsList)
            {
               newList.Add(statusEffect as IStatusEffectVisual);
            }
            return newList;
         }
      }
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
