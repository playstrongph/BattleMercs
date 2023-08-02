using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        IHeroPreviewHero HeroPreviewHero { get; }
        List<IHeroPreviewSkill> HeroPreviewSkillList { get; }
    }
}