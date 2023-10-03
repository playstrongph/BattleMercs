using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
    public interface ISkillAttributes
    {
        int SkillCooldown { get; set; }
        int SkillSpeed { get; set; }
        int SkillFightingSpirit { get; set; }
        int SkillFocusPoints { get; set; }
        int BaseSkillCooldown { get; set; }
        int FightingSpiritCost { get; set; }
        int FocusPointsCost { get; set; }
        int SkillStackingCounters { get; set; }
        int StackingCountersLimit { get; set; }
        int BaseSkillSpeed { get; set; }
        ISkillElementAsset SkillElementAsset { get; set; }
        ISkillTypeAsset SkillType { get; set; }
        ISkillReadinessAsset SkillReadiness { get; set; }
        ISkillEnableStatusAsset SkillEnableStatus { get; set; }
        ISkillTargetAsset SkillTargetAsset { get; set; }
    }
}
