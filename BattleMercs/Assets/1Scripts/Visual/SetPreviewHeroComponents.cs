using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetPreviewHeroComponents : MonoBehaviour, ISetPreviewHeroComponents
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewVisual))] private Object heroPreviewVisual;
      
#pragma warning restore 0649


      #endregion

      #region PROPERTIES

      private IHeroPreviewVisual HeroPreviewVisual => heroPreviewVisual as IHeroPreviewVisual;

      #endregion

      #region METHODS

      public void UpdateHeroPreviewGameObjectName()
      {
          HeroPreviewVisual.ThisTransform.gameObject.name = HeroPreviewVisual.HeroLogicReference.HeroInformation.HeroName + "HeroPreview";
      }

      public void UpdateHeroPreviewFrame()
      {
          HeroPreviewVisual.HeroLogicReference.HeroInformation.HeroElement.SetHeroPreviewClassColor(HeroPreviewVisual);
      }
      
      public void UpdateHeroPreviewAttackText()
      {
          var attackValue = HeroPreviewVisual.HeroLogicReference.HeroAttributes.Attack;

          HeroPreviewVisual.HeroPreviewHero.AttackText.text = attackValue.ToString();
      }
      
      public void UpdateHeroPreviewHealthText()
      {
          var healthValue = HeroPreviewVisual.HeroLogicReference.HeroAttributes.Health;

          HeroPreviewVisual.HeroPreviewHero.HealthText.text = healthValue.ToString();
      }

      public void UpdateHeroPreviewArmorText()
      {
          var armorValue = HeroPreviewVisual.HeroLogicReference.HeroAttributes.Armor;
          
          HeroPreviewVisual.HeroPreviewHero.ArmorText.text = armorValue.ToString();

          //Hide Armor image if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.Armor.enabled = armorValue > 0;
          
          //Hide Armor text if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.ArmorText.enabled = armorValue > 0;
      }
      
      public void UpdateHeroPreviewNameText()
      {
          var nameValue = HeroPreviewVisual.HeroLogicReference.HeroInformation.HeroName;

          HeroPreviewVisual.HeroPreviewHero.NameText.text = nameValue;
      }
      
      public void UpdateHeroPreviewClassText()
      {
          var nameValue = HeroPreviewVisual.HeroLogicReference.HeroInformation.HeroClass.ToString();

          HeroPreviewVisual.HeroPreviewHero.ClassText.text = nameValue;
      }

      
      
      

      #endregion
   }
}
