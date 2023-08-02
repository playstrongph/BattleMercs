using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ICombatButtonVisual
    {
        Canvas Canvas { get; }
        void SetButtonText(string text);
        void SetGreyButton();
        void SetGreenButton();
        void SetYellowButton();
    }
}