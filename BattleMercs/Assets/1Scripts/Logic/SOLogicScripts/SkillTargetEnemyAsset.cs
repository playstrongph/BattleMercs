﻿using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillTargetEnemy", menuName = "Assets/SkillTargets/SkillTargetEnemy")]
   public class SkillTargetEnemyAsset : SkillTargetAsset
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
