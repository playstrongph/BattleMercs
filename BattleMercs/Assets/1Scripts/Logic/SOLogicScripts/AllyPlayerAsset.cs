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
      
      
      public override void DisplayHeroSkills(IHeroLogic heroLogic)
      {
        Debug.Log("Ally Player DisplayHeroSkills");
      }

      public override void ScaleDownHero(IHeroLogic heroLogic)
      {
          Debug.Log("Ally Player ScaleDownHero");
      }
      
      public override void ScaleUpHero(IHeroLogic heroLogic)
      {
          Debug.Log("Ally Player ScaleUpHero");
      }
        

      #endregion
   }
}
