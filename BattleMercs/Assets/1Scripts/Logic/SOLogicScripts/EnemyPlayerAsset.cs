using _1Scripts.Visual;
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
      
      public override  void ScaleDownHero(IHeroVisual heroVisual)
      {
         heroVisual.Transform.localScale = new Vector3(1,1,1);
      }
      
      public override void ScaleUpHero(IHeroVisual heroVisual, Vector3 newScale)
      {
        
         heroVisual.Transform.localScale = newScale;
      }
      
        

      #endregion
   }
}
