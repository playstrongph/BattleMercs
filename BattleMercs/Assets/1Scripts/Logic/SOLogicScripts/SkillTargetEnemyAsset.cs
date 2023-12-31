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

      public override List<IHeroLogic> GetSkillTargets(IHeroLogic heroLogic)
      {
         //return the living enemy heroes
         //TODO: In the future, shall be influenced by stealth and taunt 
         return heroLogic.PlayerReference.CurrentEnemyPlayer.AliveHeroes;
      }

      


      #endregion
   }
}
