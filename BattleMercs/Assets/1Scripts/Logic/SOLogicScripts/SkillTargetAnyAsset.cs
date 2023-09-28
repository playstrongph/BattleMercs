using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillTargetAny", menuName = "Assets/SkillTargets/SkillTargetAny")]
   public class SkillTargetAnyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic heroLogic)
      {
         
         //TODO: return the enemy target
         return new List<IHeroLogic>();
      }


      #endregion
   }
}
