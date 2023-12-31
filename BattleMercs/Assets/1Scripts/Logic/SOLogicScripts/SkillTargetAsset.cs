using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillTargetAsset : ScriptableObject, ISkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Get skill targets based on the perspective of the caster hero
      /// </summary>
      /// <param name="castHeroLogic"></param>
      /// <returns></returns>
      public virtual List<IHeroLogic> GetSkillTargets(IHeroLogic castHeroLogic)
      {
         return new List<IHeroLogic>();
      }
      
      /// <summary>
      /// Displays the hero glows based on skill target type
      /// </summary>
      /// <param name="castHeroLogic"></param>
      public virtual void ShowHeroGlows(IHeroLogic castHeroLogic)
      {
         
      }
      
      /// <summary>
      /// Hide All Hero Glows, regardless of skill target type 
      /// </summary>
      /// <param name="castHeroLogic"></param>
      public virtual void HideHeroGlows(IHeroLogic castHeroLogic)
      {
         var allAllyHeroes = castHeroLogic.PlayerReference.PlayerHeroes;
         var allEnemyHeroes = castHeroLogic.PlayerReference.CurrentEnemyPlayer.PlayerHeroes;
         var allHeroes = new List<IHeroLogic>();
         
         allHeroes.Clear();
         
         allHeroes.AddRange(allEnemyHeroes);
         allHeroes.AddRange(allAllyHeroes);

         foreach (var hero in allHeroes)
         {
            hero.HeroVisualReference.HeroGlows.HideHeroGlow();
         }
      }


      #endregion
   }
}
