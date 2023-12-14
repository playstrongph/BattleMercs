using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillReadinessAsset : ScriptableObject, ISkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      
      //VISUAL Methods
      public virtual void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         
      }
      
      public virtual void UpdateSkillReadinessVisual(ISkillVisual skillVisual)
      {
         //Active Skill - check skill readiness status 
         //Passive Skill - Set Passive skill canvas enabled, others disabled
         //Basic Skill - Set Skill Ready Canvas enabled, others disabled
         
      }


      #endregion
   }
}
