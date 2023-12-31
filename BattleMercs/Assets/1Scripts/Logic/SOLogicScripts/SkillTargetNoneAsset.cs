using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillTargetNone", menuName = "Assets/SkillTargets/SkillTargetNone")]
   public class SkillTargetNoneAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic castHeroLogic)
      {
         //return an empty list
         return new List<IHeroLogic>();
      }


      #endregion
   }
}
