using _1Scripts.Logic;
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

        Image HeroGraphic { get; set; }
        TextMeshProUGUI AttackText { get; set; }
        TextMeshProUGUI HealthText { get; set; }
        TextMeshProUGUI ArmorText { get; set; }
        TextMeshProUGUI TurnOrderText { get; set; }

        IHeroLogic HeroLogicReference { get; set; }

        ISetHeroVisuals SetHeroVisuals { get; set; }

        Transform Transform { get; }
    }
}