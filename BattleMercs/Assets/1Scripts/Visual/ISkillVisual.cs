using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillVisual
    {
        ISkillVisualInputActions SkillVisualInputActions { get; }
        BoxCollider SkillVisualCollider { get; }
        Transform SkillReadyVisualTransform { get; }
        Transform SkillNotReadyVisualTransform { get; }
        Transform PassiveSkillVisualTransform { get; }
        Image SkillReadyGraphic { get; }
        Image SkillNotReadyGraphic { get; }
        Image PassiveSkillGraphic { get; }
        Canvas SkillReadyCanvas { get; }
        Canvas SkillNotReadyCanvas { get; }
        Canvas PassiveSkillCanvas { get; }
        TextMeshProUGUI SpeedText { get; }
        TextMeshProUGUI CooldownText { get; }
    }
}