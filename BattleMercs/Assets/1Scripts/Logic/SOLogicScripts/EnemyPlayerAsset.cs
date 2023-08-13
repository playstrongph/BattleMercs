using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    [CreateAssetMenu(fileName = "EnemyPlayer", menuName = "Assets/PlayerAlliance/EnemyPlayer")]
   public class EnemyPlayerAsset : PlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      
      public override void DisplayHeroSkills(IHeroLogic heroLogic)
      {
        Debug.Log("Enemy Player DisplayHeroSkills");
      }

      public override void ScaleDownHero(IHeroLogic heroLogic)
      {
          Debug.Log("Enemy Player ScaleDownHero");
      }
      
      public override void ScaleUpHero(IHeroLogic heroLogic)
      {
          Debug.Log("Enemy Player ScaleUpHero");
      }
        

      #endregion
   }
}
