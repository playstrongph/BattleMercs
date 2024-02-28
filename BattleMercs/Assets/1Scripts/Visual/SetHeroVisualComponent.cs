using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetHeroVisualComponent : MonoBehaviour, ISetHeroVisualComponent
   {
      #region VARIABLES

   #pragma warning disable 0649
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;
      
      
#pragma warning restore 0649

      #endregion

      #region PROPERTIES
      
      private IHeroVisual HeroVisual => heroVisual as IHeroVisual;


      #endregion

      #region METHODS

      public void UpdateGameObjectHeroName(string heroName)
      {
         HeroVisual.Transform.gameObject.name = heroName;
      }

      public void ShowHeroVisual()
      {
         HeroVisual.Canvas.enabled = true;
      }
      
      public void HideHeroVisual()
      {
         HeroVisual.Canvas.enabled = false;
      }

      public void ShowHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }
      
      public void HideHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }

      public void UpdateHeroFrameColorVisual(IHeroElementAsset heroElement)
      {
         heroElement.SetHeroClassColor(HeroVisual);
      }

      public void UpdateArmorTextAndImage(int armorValue)
      {
         var armorImage = HeroVisual.ArmorImage;
         var armorText = HeroVisual.ArmorText;
         
         //display armor image and text
         if (armorValue > 0)
         {
            armorImage.enabled = true;
            armorText.enabled = true;

            armorText.text = armorValue.ToString();
         }
         //hide armor image and set text to blank
         else
         {
            armorImage.enabled = false;
            armorText.enabled = false;

            armorText.text = " ";
         }
      }
      
      /// <summary>
      /// Displays the turn order image 
      /// </summary>
      public void ShowTurnOrderImage()
      {
         HeroVisual.TurnOrderImage.enabled = true;
      }
      
      /// <summary>
      /// Hides the turn order image
      /// </summary>
      public void HideTurnOrderImage()
      {
         HeroVisual.TurnOrderImage.enabled = false;
      }
      

      /// <summary>
      /// Set the Hero Graphic
      /// </summary>
      /// <param name="graphic"></param>
      public void UpdateHeroGraphic(Sprite graphic)
      {
         var heroGraphic = HeroVisual.HeroGraphic;

         heroGraphic.sprite = graphic;
      }
      
      /// <summary>
      /// Update the attack text
      /// </summary>
      public void UpdateAttackText()
      {
         var attackValue = HeroVisual.HeroLogicReference.HeroAttributes.Attack;
         
         //This clamps the attack text value to a min of zero
         var textValue = Mathf.Max(0, attackValue);
         
         HeroVisual.AttackText.text = textValue.ToString();
      }
      
      /// <summary>
      /// Update the health text
      /// </summary>
      public void UpdateHealthText()
      {
         var healthValue = HeroVisual.HeroLogicReference.HeroAttributes.Health;
         //This clamps the health text value to a min of zero
         var textValue = Mathf.Max(0, healthValue);
         
         HeroVisual.HealthText.text = textValue.ToString();
      }
      
      /// <summary>
      /// Sets the turn order text
      /// </summary>
      public void UpdateTurnOrderText(int turnOrderValue)
      {
         var textValue = Mathf.Max(0, turnOrderValue);
         var ellipsis = "...";

         HeroVisual.TurnOrderText.text = textValue.ToString();

         if (turnOrderValue <= 0)
            HeroVisual.TurnOrderText.text = ellipsis;
      }











      #endregion
   }
}
