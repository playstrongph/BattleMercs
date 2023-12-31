using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillTargetAlly", menuName = "Assets/SkillTargets/SkillTargetAlly")]
   public class SkillTargetAllyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic castHeroLogic)
      {
         //TODO: return all the ally heroes
         //TODO: In the future, shall be influenced by stealth and taunt 
         return castHeroLogic.PlayerReference.AliveHeroes;
      }
      
      public override void ShowHeroGlows(IHeroLogic castHeroLogic)
      {
         var heroTargets = GetSkillTargets(castHeroLogic);
         
         foreach (var heroTarget in heroTargets)
         {
            heroTarget.HeroVisualReference.HeroGlows.SetColorYellow();
            heroTarget.HeroVisualReference.HeroGlows.ShowHeroGlow();
         }
      }


      #endregion
   }
}
