using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Logic
{
   public interface IHeroInformation
   {
      string HeroName  { get; set; }
      int HeroLevel { get; set;}
      int HeroStars { get; set;}
      int CumulativePower { get; set; }
      Sprite HeroGraphic { get; set; }
      IHeroElementAsset HeroElement { get; set;}
      IHeroClassAsset HeroClass { get; set;}
      IHeroZodiacAsset HeroZodiac { get; set;}
   }
}
