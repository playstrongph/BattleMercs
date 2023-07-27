namespace _1Scripts.Visual
{
    public interface IHeroGlowsVisual
    {
        void ShowHeroGlow();
        void HideHeroGlow();

        /// <summary>
        /// Red if target is an enemy
        /// </summary>
        void SetColorRed();

        /// <summary>
        /// Green if target is an ally
        /// </summary>
        void SetColorGreen();

        /// <summary>
        /// Yellow if any target
        /// </summary>
        void SetColorYellow();
    }
}