using TMPro;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewHero
    {
        IHeroFramesVisual HeroFramesVisual { get; }
        Image Armor { get; }
        Image NamePlate { get; }
        Image ClassPlate { get; }
        TextMeshProUGUI AttackText { get; set; }
        TextMeshProUGUI HealthText { get; set; }
        
        TextMeshProUGUI ArmorText { get; set; }
        TextMeshProUGUI NameText { get; set; }
        TextMeshProUGUI ClassText { get; set; }
    }
}