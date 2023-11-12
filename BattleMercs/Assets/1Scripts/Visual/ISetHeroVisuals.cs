using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ISetHeroVisuals
    {

        void SetGameObjectHeroName(string heroName);

        void ShowHeroVisual();
        void HideHeroVisual();
        
        void ShowHeroGlowVisual();
        void HideHeroGlowVisual();

        /// <summary>
        /// Hero Frame depends on the hero Element
        /// </summary>
        void SetHeroFrameColorVisual();

        /// <summary>
        /// Updates the armor text and armor image display
        /// </summary>
        /// 
        void UpdateArmorTextAndImage();

        /// <summary>
        /// Displays the turn order image 
        /// </summary>
        void ShowTurnOrderImage();

        /// <summary>
        /// Hides the turn order image
        /// </summary>
        void HideTurnOrderImage();

        /// <summary>
        /// Set the Hero Graphic
        /// </summary>
        /// <param name="graphic"></param>
        void SetHeroGraphic(Sprite graphic);

        /// <summary>
        /// Update the attack text
        /// </summary>
        void UpdateAttackText();

        /// <summary>
        /// Update the health text
        /// </summary>
        void UpdateHealthText();

        /// <summary>
        /// Sets the turn order text
        /// </summary>
        void UpdateTurnOrderText(int turnOrderValue);
    }
}