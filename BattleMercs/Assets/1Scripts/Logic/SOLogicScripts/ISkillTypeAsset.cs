using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillTypeAsset
    {
        void StartSkillTargetingVisual(ISkillVisual skillVisual, ISelectSkillTargetVisual selectSkillTargetVisual);

        void EnableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill);
        
        void DisableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill);

        void SetSkillPreviewCooldownGraphic(ISkillPreviewVisual skillPreview);

        void UpdateSkillReadinessVisual(ISkillVisual skillVisual);

        void UpdateSkillSpeedText(ISkillVisual skillVisualReference, int speedValue);

        void UpdateSkillCooldownText(ISkillVisual skillVisualReference, int skillCooldown);
    }
}