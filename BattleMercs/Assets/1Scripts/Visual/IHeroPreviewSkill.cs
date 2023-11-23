using TMPro;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewSkill
    {
        ISkillPreviewFrames SkillPreviewFrames { get; }
        Image SkillPreviewGraphic { get; }
        Image CooldownGraphic { get; }
        Image SpeedGraphic { get; }
        TextMeshProUGUI CooldownText { get; }
        TextMeshProUGUI SpeedText { get; }
        TextMeshProUGUI SkillNameText { get; }
        TextMeshProUGUI SkillElementText { get; }
        TextMeshProUGUI SkillDescriptionText { get; }
    }
}