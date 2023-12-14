using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillNotReady", menuName = "Assets/SkillReadiness/SkillNotReady")]
   public class SkillNotReadyAsset : SkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      
      //VISUAL Methods
      public override void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual) { }
      
      
      public override void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
 
         //Skill not ready settings
         skillVisual.SkillNotReadyCanvas.enabled = true;
         
         skillVisual.SkillReadyCanvas.enabled = false;
         skillVisual.PassiveSkillCanvas.enabled = false;
        
      }


      #endregion
   }
}
