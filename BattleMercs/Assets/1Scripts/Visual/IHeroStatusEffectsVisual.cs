using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IHeroStatusEffectsVisual
    {
        List<IStatusEffectVisual> StatusEffectsList { get; }
    }
}