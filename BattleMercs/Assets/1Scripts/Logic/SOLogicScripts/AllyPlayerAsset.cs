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
      
      public override void UpdateSelectedHeroVisual(ISelectHeroVisual selectHeroVisual)
      {
          selectHeroVisual.UpdateSelectedHeroVisual();
      }
      
      
     
        

      #endregion
   }
}
