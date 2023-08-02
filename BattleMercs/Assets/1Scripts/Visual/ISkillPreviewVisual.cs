using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillPreviewVisual
    {
        Canvas Canvas { get; }
        ISkillPreviewFrames SkillPreviewFrames { get; }
        Image SkillGraphic { get; }
        Image CooldownGraphic { get; }
        Image SpeedGraphic { get; }
        TextMeshProUGUI NameText { get; }
        TextMeshProUGUI ElementText { get; }
        TextMeshProUGUI DescriptionText { get; }
        TextMeshProUGUI CooldownText { get; }
        TextMeshProUGUI SpeedText { get; }
    }
}