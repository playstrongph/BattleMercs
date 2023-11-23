using System.Collections.Generic;
using _1Scripts.Logic;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        IHeroPreviewHero HeroPreviewHero { get; }
        List<IHeroPreviewSkill> HeroPreviewSkillList { get; }

        IHeroLogic HeroLogicReference { get; set; }
    }
}