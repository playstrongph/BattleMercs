using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface ISkillHistoryVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        List<IUsedSkillHistoryVisual> UsedSkillHistoryVisualList { get; }
    }
}