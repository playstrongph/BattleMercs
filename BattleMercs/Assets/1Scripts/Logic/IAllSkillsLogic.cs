using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IAllSkillsLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<ISkillLogic> AllSkills { get; }
    }
}