using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetHeroVisuals : MonoBehaviour, ISetHeroVisuals
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

      public void SetGameObjectHeroName(string heroName)
      {
         HeroVisual.Transform.gameObject.name = heroName;
      }

      public void ShowHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }
      
      public void HideHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }
      
      /// <summary>
      /// Hero Frame depends on the hero Element
      /// </summary>
      public void SetHeroFrameColorVisual()
      {
         var heroLogic = HeroVisual.HeroLogicReference;
         
         heroLogic.HeroInformation.HeroElement.SetClassColor(heroLogic);
      }
      
      /// <summary>
      /// Updates the armor text and armor image display
      /// </summary>
      /// 
      public void UpdateArmorTextAndImage()
      {
         var heroArmorValue = HeroVisual.HeroLogicReference.HeroAttributes.Armor;
         
         var armorImage = HeroVisual.ArmorImage;
         var armorText = HeroVisual.ArmorText;
         
         //display armor image and text
         if (heroArmorValue > 0)
         {
            armorImage.enabled = true;
            armorText.enabled = true;

            armorText.text = heroArmorValue.ToString();
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
      public void SetHeroGraphic(Sprite graphic)
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

         HeroVisual.TurnOrderText.text = textValue.ToString();
      }











      #endregion
   }
}
