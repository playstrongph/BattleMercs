namespace _1Scripts.Visual
{
    public interface IUsedSkillPreviewVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        IUsedSkillSingleTargetVisual UsedSkillSingleTargetVisual { get; }
        IUsedSkillMultiTarget UsedSkillMultiTarget { get; }
        ISkillUsedVisual SkillUsedVisual { get; }
    }
}