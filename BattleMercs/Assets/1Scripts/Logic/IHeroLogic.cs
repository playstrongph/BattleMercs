using System.Collections.Generic;
using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IHeroLogic
    {
      
        IHeroInformation HeroInformation { get; }

        IHeroAttributes HeroAttributes { get; }

        ISetHeroVisualAndLogicReferences SetHeroVisualAndLogicReferences { get; }
        List<ISkillLogic> HeroSkillsReference { get; }

        IPlayerLogic PlayerReference { get; set; }

        IHeroVisual HeroVisualReference { get; set; }

        Transform Transform { get; }

        void AddToHeroSkillsList(ISkillLogic skillLogic);

    }
}