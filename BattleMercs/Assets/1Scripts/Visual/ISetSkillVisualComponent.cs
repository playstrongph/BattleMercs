using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ISetSkillVisualComponent
    {
        /// <summary>
        /// Checks skill type and skill readiness before updating the skill readiness visual
        /// </summary>
        void UpdateSkillReadinessVisual(ISkillTypeAsset skillType);

        void UpdateSkillGraphic(Sprite skillGraphic);

        void UpdateSkillSpeedText(ISkillTypeAsset skillType, int skillSpeedValue);
        void UpdateSkillCooldownText(ISkillTypeAsset skillType, int skillCooldown);
    }
}