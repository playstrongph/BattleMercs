using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface ISkillHistoryVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        List<IUsedSkillHistoryVisual> UsedSkillHistoryVisualList { get; }
    }
}