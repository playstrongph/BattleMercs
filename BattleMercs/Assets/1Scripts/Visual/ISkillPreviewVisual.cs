using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillPreviewVisual
    {

        void ShowSkillPreviewVisual(ISkillVisual skillVisual);

        void HideSkillPreviewVisual();

        ISetSkillPreviewComponents SetSkillPreviewComponents { get; }
        ISkillVisual SkillVisualReference { get; set;}
        Canvas Canvas { get; }

        Transform ThisTransform { get; }
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