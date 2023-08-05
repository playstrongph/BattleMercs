namespace _1Scripts.Visual
{
    public interface IUsedSkillPreviewVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        IUsedSkillSingleTargetVisual UsedSkillSingleTargetVisual { get; }
        IUsedSkillMultiTarget UsedSkillMultiTarget { get; }
        ISkillUsedVisual SkillUsedVisual { get; }
    }
}