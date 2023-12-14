namespace _1Scripts.Visual
{
    public interface ISetSkillVisualComponent
    {
        /// <summary>
        /// Checks skill type and skill readiness before updating the skill readiness visual
        /// </summary>
        void UpdateSkillReadinessVisual();

        void UpdateSkillGraphic();

        void UpdateSkillSpeedText();
        void UpdateSkillCooldownText();
    }
}