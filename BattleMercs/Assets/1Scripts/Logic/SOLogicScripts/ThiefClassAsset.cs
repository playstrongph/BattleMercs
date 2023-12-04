using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "ThiefClass", menuName = "Assets/HeroClass/ThiefClass")]
   public class ThiefClassAsset : HeroClassAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic) 
      {

      }
      
      public override string ClassName => "Thief";
        

      #endregion
   }
}
