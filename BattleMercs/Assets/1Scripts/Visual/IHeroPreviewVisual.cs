using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        IHeroPreviewHero HeroPreviewHero { get; }
        List<IHeroPreviewSkill> HeroPreviewSkillList { get; }
    }
}