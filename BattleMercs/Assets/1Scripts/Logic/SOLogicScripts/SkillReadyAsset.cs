using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillReady", menuName = "Assets/SkillReadiness/SkillReady")]
   public class SkillReadyAsset : SkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      
      /// <summary>
      /// Start skill targeting when skill is enabled and skill is ready
      /// </summary>
      /// <param name="skillVisual"></param>
      /// <param name="selectSkillTargetVisual"></param>
      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         selectSkillTargetVisual.StartSkillTargeting(skillVisual);
      }
      
      public override void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
 
         //Skill ready settings
         skillVisual.SkillReadyCanvas.enabled = true;
         
         skillVisual.PassiveSkillCanvas.enabled = false;
         skillVisual.SkillNotReadyCanvas.enabled = false;
      }


      #endregion
   }
}
