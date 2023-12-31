using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "SkillTargetAny", menuName = "Assets/SkillTargets/SkillTargetAny")]
   public class SkillTargetAnyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic castHeroLogic)
      {
         //TODO: In the future, shall be influenced by stealth and taunt 
         var allLivingHeroes = new List<IHeroLogic>();
         var enemyLivingHeroes = castHeroLogic.PlayerReference.CurrentEnemyPlayer.AliveHeroes;
         var allyLivingHeroes = castHeroLogic.PlayerReference.AliveHeroes;
         
         //Combine lists
         allLivingHeroes.AddRange(enemyLivingHeroes);
         allLivingHeroes.AddRange(allyLivingHeroes);

         return allLivingHeroes;
      }
      
      public override void ShowHeroGlows(IHeroLogic castHeroLogic)
      {
         var heroTargets = GetSkillTargets(castHeroLogic);
         
         foreach (var heroTarget in heroTargets)
         {
            heroTarget.HeroVisualReference.HeroGlows.SetColorGreen();
            heroTarget.HeroVisualReference.HeroGlows.ShowHeroGlow();
         }
      }


      #endregion
   }
}
