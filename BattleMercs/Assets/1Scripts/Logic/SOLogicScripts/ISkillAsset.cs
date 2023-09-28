using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillAsset
    {
        string SkillName { get; }
        string SkillDescription { get; }
        Sprite SkillSprite { get; }
        int SkillCooldown { get; }
        int SkillSpeed { get; }
        int SkillFightingSpirit { get; }
        int FightingSpiritCost { get; }
        int BaseSkillCooldown { get; }
        int BaseSkillSpeed { get; }
        ISkillElementAsset SkillElement { get; }
        ISkillTypeAsset SkillType { get; }
        ISkillReadinessAsset SkillReadiness { get; }
        ISkillEnableStatusAsset SkillEnableStatus { get; }
        ISkillTargetAsset SkillTarget { get; }
    }
}