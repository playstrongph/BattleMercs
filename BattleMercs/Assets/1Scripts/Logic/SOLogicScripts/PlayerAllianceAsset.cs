using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class PlayerAllianceAsset : ScriptableObject, IPlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void DisplayHeroSkills(IHeroSkillsVisual heroSkillsVisual, IHeroLogic heroLogic)
      {
         /*
         //Logic below is for ally heroes only 
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         hero.HeroTransform.localScale = newScale;
         */
      }

      public virtual void ScaleDownHero(IHeroVisual heroVisual)
      {
         
      }
      
      public virtual void ScaleUpHero(IHeroVisual heroVisual, Vector3 newScale)
      {
         
      }

      #endregion
   }
}
