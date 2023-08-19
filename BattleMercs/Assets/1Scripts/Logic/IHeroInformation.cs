using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
   public interface IHeroInformation
   {
      string HeroName  { get; }
         
      int HeroLevel { get; }
      int HeroStars { get; }
      int HeroCp { get; }
      IHeroClassAsset HeroClass { get; }

      IHeroRaceAsset HeroRace { get; }
   }
}
