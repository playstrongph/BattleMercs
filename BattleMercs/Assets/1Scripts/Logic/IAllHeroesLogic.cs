using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IAllHeroesLogic
    {
        List<AllHeroesLogic.IHeroLogic> AllHeroes { get; }
    }
}