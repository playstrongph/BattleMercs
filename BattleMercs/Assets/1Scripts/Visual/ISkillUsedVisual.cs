using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillUsedVisual
    {
        ISkillPreviewFrames SkillPreviewFrames { get; }
        IHeroFramesVisual HeroFramesVisual { get; }
        Canvas Canvas { get; }
        Image SkillGraphic { get; }
        Image CooldownImage { get; }
        Image SpeedImage { get; }
        Image ArrowGlowImage { get; }
        Image ArrowImage { get; }
        Image HeroImage { get; }
        TextMeshProUGUI NameText { get; }
        TextMeshProUGUI ElementText { get; }
        TextMeshProUGUI DescriptionText { get; }
        TextMeshProUGUI CooldownText { get; }
        TextMeshProUGUI SpeedText { get; }
    }
}