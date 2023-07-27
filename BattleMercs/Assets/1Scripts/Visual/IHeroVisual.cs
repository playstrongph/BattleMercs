using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IHeroVisual
    {
        IHeroGlowsVisual HeroGlows { get; }
        IHeroFramesVisual HeroFrames { get; }
        IHeroStatusEffectsVisual HeroStatusEffectsVisual { get; }
        Image ArmorImage { get; }
        Image TurnOrderImage { get; }
        TextMeshProUGUI AttackText { get; }
        TextMeshProUGUI HealthText { get; }
        TextMeshProUGUI ArmorText { get; }
        TextMeshProUGUI TurnOrderText { get; }

        Transform Transform { get; }
    }
}