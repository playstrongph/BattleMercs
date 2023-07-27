using UnityEngine;

namespace _1Scripts.Visual
{
    public interface IStatusEffectVisual
    {
        void SetFrame(Sprite newFrame);
        void SetIcon(Sprite newIcon);
        void SetCounters(int newCounters);
        void ShowStatusEffectVisual();
        void HideStatusEffectVisual();
    }
}