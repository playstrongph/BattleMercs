using _1Scripts.Logic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _1Scripts.Visual
{
    public interface IBattleSceneVisualManager
    {
        //Inspector References
        IBattleSceneLogicManager BattleSceneLogicManager { get; set; }
        IGameBoardVisual GameBoardVisual { get; }
        IPlayerVisual MainPlayerVisual { get; }
        IPlayerVisual EnemyPlayerVisual { get; }
        IHeroSkillsVisual HeroSkillsVisual { get; }
        ISkillHistoryVisual SkillHistoryVisual { get; }
        ICombatButtonVisual CombatButtonVisual { get; }
        IHeroPreviewVisual HeroPreviewVisual { get; }
        ISkillPreviewVisual SkillPreviewVisual { get; }
        IUsedSkillPreviewVisual UsedSkillPreviewVisual { get; }
        ISkillTargetingVisual SkillTargetingVisual { get; }
        IDisplaySkillTargetingVisual DisplaySkillTargetingVisual { get; }
        Camera BattleSceneCamera { get; }
        EventSystem VisualEventSystem { get; }

        Transform ThisTransform { get; }
    }
}