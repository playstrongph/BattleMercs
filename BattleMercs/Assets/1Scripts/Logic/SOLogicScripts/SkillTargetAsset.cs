using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillTargetAsset : ScriptableObject, ISkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual List<IHeroLogic> GetSkillTargets(IHeroLogic heroLogic)
      {
         return new List<IHeroLogic>();
      }


      #endregion
   }
}
