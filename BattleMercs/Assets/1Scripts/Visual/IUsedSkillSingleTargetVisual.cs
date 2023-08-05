using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IUsedSkillSingleTargetVisual
    {
        IHeroFramesVisual HeroFramesVisual { get; }
        Canvas Canvas { get; }
        Transform ThisTransform { get; }
        Image ArmorImage { get; }
        Image NamePlateImage { get; }
        Image RacePlateImage { get; }
        Image DamageGraphic { get; }
        Image CriticalDamageGraphic { get; }
        TextMeshProUGUI AttackText { get; }
        TextMeshProUGUI HealthText { get; }
        TextMeshProUGUI ArmorText { get; }
        TextMeshProUGUI NameText { get; }
        TextMeshProUGUI RaceText { get; }
        TextMeshProUGUI DamageText { get; }
    }
}