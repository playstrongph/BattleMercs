using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "KnightClass", menuName = "Assets/HeroClass/KnightClass")]
   public class KnightClassAsset : HeroClassAsset
   {
      #region METHODS
      
      public override void SetClassColor(IHeroLogic heroLogic) 
      {

      }
      
      public override string ClassName => "Knight";

      #endregion
   }
}
