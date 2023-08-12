namespace _1Scripts.Visual
{
    public interface ISelectSkillTargetVisual
    {
        ISkillTargetingVisual SkillTargetingVisual { get; }
        void SkillTargetingPermissiveChecks(ISkillVisual skillVisual);

        void StartSkillTargeting(ISkillVisual skillVisual);
    }
}