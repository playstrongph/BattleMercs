using _1Scripts.Visual;
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
      
      
      
      /// <summary>
      /// Check Skill Readiness Status
      /// </summary>
      /// <param name="skillVisual"></param>
      /// <param name="selectSkillTargetVisual"></param>
      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         var skillReadiness = skillVisual.SkillLogicReference.SkillAttributes.SkillReadiness;
         
         skillReadiness.StartSkillTargetingVisual(skillVisual, selectSkillTargetVisual);
      }


      #endregion
   }
}
