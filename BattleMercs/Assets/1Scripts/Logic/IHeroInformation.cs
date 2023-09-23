using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
   public interface IHeroInformation
   {
      string HeroName  { get; }
         
      int HeroLevel { get; }
      int HeroStars { get; }
      int CumulativePower { get; }
      IHeroElementAsset HeroElement { get; }
      IHeroClassAsset HeroClass { get; }

      IHeroZodiacAsset HeroZodiac { get; }
   }
}
