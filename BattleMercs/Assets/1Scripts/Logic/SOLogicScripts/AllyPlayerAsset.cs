using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    [CreateAssetMenu(fileName = "AllyPlayer", menuName = "Assets/PlayerAlliance/AllyPlayer")]
   public class AllyPlayerAsset : PlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override void DisplayHeroSkills(IHeroSkillsVisual heroSkillsVisual,IHeroLogic heroLogic)
      {
          
          heroSkillsVisual.ShowHeroSkillsVisual(heroLogic);
      }
      
      public override  void ScaleDownHero(IHeroVisual heroVisual)
      {
         
      }
      
      public override void ScaleUpHero(IHeroVisual heroVisual, Vector3 newScale)
      {
         
      }
     
        

      #endregion
   }
}
