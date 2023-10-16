using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IAllSkillsLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<ISkillLogic> AllSkills { get; }

        void AddToAllSkillsList(ISkillLogic newSkill);

        Transform Transform { get; }
    }
}