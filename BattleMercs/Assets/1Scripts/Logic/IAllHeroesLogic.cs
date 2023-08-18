using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IAllHeroesLogic
    {
        List<IHeroLogic> AllHeroes { get; }
    }
}