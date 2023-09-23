using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IHeroLogic
    {
        string HeroLabel { get; set; }
        IHeroInformation HeroInformation { get; }

        IHeroAttributes HeroAttributes { get; }
        List<ISkillLogic> HeroSkills { get; }

    }
}