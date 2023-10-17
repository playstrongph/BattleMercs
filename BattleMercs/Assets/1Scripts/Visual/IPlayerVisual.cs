using System.Collections.Generic;
using _1Scripts.Logic;

namespace _1Scripts.Visual
{
    public interface IPlayerVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        IPlayerLogic PlayerLogicReference { get; set; }
        List<IHeroVisual> HeroVisualsList { get; }
    }
}