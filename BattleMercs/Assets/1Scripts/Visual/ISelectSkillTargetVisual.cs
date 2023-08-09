namespace _1Scripts.Visual
{
    public interface ISelectSkillTargetVisual
    {
        ISkillTargetingVisual SkillTargetingVisual { get; }
        void SelectingSkillTarget(ISkillVisual skillVisual);
    }
}