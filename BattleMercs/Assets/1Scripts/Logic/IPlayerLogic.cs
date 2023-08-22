
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
   public interface IPlayerLogic
   {
      string PlayerName { get; set; }
      IPlayerNumberAsset PlayerIDNumber { get; set; }
      int SoulsCount { get; set; }

      IHeroLogic CurrentEnemyPlayer { get; set; }

      List<IHeroLogic> PlayerHeroes { get; }
      List<IHeroLogic> AliveHeroes { get; }
      List<IHeroLogic> DeadHeroes { get; }
      List<IHeroLogic> ExtinctHeroes { get; }
   }
}
