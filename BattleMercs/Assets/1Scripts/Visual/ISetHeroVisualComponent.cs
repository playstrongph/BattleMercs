using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ISetHeroVisualComponent
    {

        void UpdateGameObjectHeroName(string heroName);

        void ShowHeroVisual();
        void HideHeroVisual();
        
        void ShowHeroGlowVisual();
        void HideHeroGlowVisual();


        /// <summary>
        /// Hero Frame depends on the hero Element
        /// </summary>
        /// <param name="heroElement"></param>
        void UpdateHeroFrameColorVisual(IHeroElementAsset heroElement);

        /// <summary>
        /// Updates the armor text and armor image display
        /// </summary>
        void UpdateArmorTextAndImage(int armorValue);

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
        void UpdateHeroGraphic(Sprite graphic);

        /// <summary>
        /// Update the attack text
        /// </summary>
        void UpdateAttackText(int attackValue);

        /// <summary>
        /// Update the health text
        /// </summary>
        void UpdateHealthText(int healthValue);

        /// <summary>
        /// Sets the turn order text
        /// </summary>
        void UpdateTurnOrderText(int turnOrderValue);
    }
}