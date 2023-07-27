using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IPlayerVisual
    {
        List<IHeroVisual> HeroVisualsList { get; }
    }
}