﻿using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillEnabled", menuName = "Assets/SkillEnableStatus/SkillEnabled")]
   public class SkillEnabledAsset : SkillEnableStatusAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      
      //VISUAL Methods
      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         //TODO: Check for Skill Readiness
      }


      #endregion
   }
}