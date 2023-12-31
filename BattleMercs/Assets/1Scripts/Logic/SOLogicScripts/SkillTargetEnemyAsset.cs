using System.Collections.Generic;
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

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic castHeroLogic)
      {
         //return the living enemy heroes
         //TODO: In the future, shall be influenced by stealth and taunt 
         return castHeroLogic.PlayerReference.CurrentEnemyPlayer.AliveHeroes;
      }
      
      public override void ShowHeroGlows(IHeroLogic castHeroLogic)
      {
         var heroTargets = GetSkillTargets(castHeroLogic);
         
         foreach (var heroTarget in heroTargets)
         {
            heroTarget.HeroVisualReference.HeroGlows.SetColorRed();
            heroTarget.HeroVisualReference.HeroGlows.ShowHeroGlow();
         }
      }
      
      
      

      


      #endregion
   }
}
