using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillTypeAsset : ScriptableObject, ISkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      
      //VISUAL Methods
      
      
      public virtual void StartSkillTargetingVisual(ISkillVisual skillVisual, ISelectSkillTargetVisual selectSkillTargetVisual)
      {
         
      }

      public virtual void SetPreviewSkillCooldownGraphic(IHeroPreviewSkill heroPreviewSkill)
      {
         //Enabled image for active skills
         //Disable image for basic and passive skills
      }
      
      
      
      


      #endregion
   }
}
