using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IPlayerVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        List<IHeroVisual> HeroVisualsList { get; }
    }
}