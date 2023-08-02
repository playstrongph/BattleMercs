using TMPro;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewHero
    {
        IHeroFramesVisual HeroFramesVisual { get; }
        Image Armor { get; }
        Image NamePlate { get; }
        Image RacePlate { get; }
        TextMeshProUGUI AttackText { get; }
        TextMeshProUGUI HealthText { get; }
        TextMeshProUGUI NameText { get; }
        TextMeshProUGUI RaceText { get; }
    }
}