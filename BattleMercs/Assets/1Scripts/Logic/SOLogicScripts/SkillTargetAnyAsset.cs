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

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic heroLogic)
      {
         //TODO: In the future, shall be influenced by stealth and taunt 
         var allLivingHeroes = new List<IHeroLogic>();
         var enemyLivingHeroes = heroLogic.PlayerReference.CurrentEnemyPlayer.AliveHeroes;
         var allyLivingHeroes = heroLogic.PlayerReference.AliveHeroes;
         
         //Combine lists
         allLivingHeroes.AddRange(enemyLivingHeroes);
         allyLivingHeroes.AddRange(allyLivingHeroes);

         return allLivingHeroes;
      }


      #endregion
   }
}
