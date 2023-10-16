using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IHeroLogic
    {
      
        IHeroInformation HeroInformation { get; }

        IHeroAttributes HeroAttributes { get; }
        List<ISkillLogic> HeroSkills { get; }

        IPlayerLogic PlayerReference { get; set; }

    }
}