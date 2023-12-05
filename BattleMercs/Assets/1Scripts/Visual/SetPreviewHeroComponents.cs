using _1Scripts.Logic;
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

      #region HeroPreviewHero Updates

      public void UpdateHeroPreviewGameObjectName()
      {
          HeroPreviewVisual.ThisTransform.gameObject.name = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroName + "HeroPreview";
      }
      
      public void UpdateHeroPreviewHeroGraphic()
      {
          var heroGraphic = HeroPreviewVisual.HeroVisualReference.HeroGraphic.sprite;

          HeroPreviewVisual.HeroPreviewHero.HeroGraphic.sprite = heroGraphic;
      }

      public void UpdateHeroPreviewFrame()
      {
          HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroElement.SetHeroPreviewClassColor(HeroPreviewVisual);
      }
      
      public void UpdateHeroPreviewAttackText()
      {
          var attackValue = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroAttributes.Attack;

          HeroPreviewVisual.HeroPreviewHero.AttackText.text = attackValue.ToString();
      }
      
      public void UpdateHeroPreviewHealthText()
      {
          var healthValue = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroAttributes.Health;

          HeroPreviewVisual.HeroPreviewHero.HealthText.text = healthValue.ToString();
      }

      public void UpdateHeroPreviewArmorText()
      {
          var armorValue = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroAttributes.Armor;
          
          HeroPreviewVisual.HeroPreviewHero.ArmorText.text = armorValue.ToString();

          //Hide Armor image if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.Armor.enabled = armorValue > 0;
          
          //Hide Armor text if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.ArmorText.enabled = armorValue > 0;
      }
      
      public void UpdateHeroPreviewNameText()
      {
          var nameValue = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroName;

          HeroPreviewVisual.HeroPreviewHero.NameText.text = nameValue;
      }
      
      public void UpdateHeroPreviewClassText()
      {
          var nameValue = HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroClass.ClassName;

          HeroPreviewVisual.HeroPreviewHero.ClassText.text = nameValue;
      }
      
      #endregion

      #region HeroPreviewSkill Updates

      public void UpdateHeroPreviewSkillFrame(IHeroPreviewSkill heroPreviewSkill)
      {
          HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroElement.SetHeroPreviewSkillClassColor(heroPreviewSkill);
      }
      
      public void UpdateSkillPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
          HeroPreviewVisual.HeroVisualReference.HeroLogicReference.HeroInformation.HeroElement.SetHeroPreviewElementText(heroPreviewSkill);
      }
      
      public void UpdateSkillPreviewDescriptionText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          var skillDescription = skillLogic.SkillInformation.SkillDescription;

          heroPreviewSkill.SkillDescriptionText.text = skillDescription;
      }
      
      public void UpdateSkillPreviewGraphic(IHeroPreviewSkill heroPreviewSkill,ISkillLogic skillLogic)
      {
          heroPreviewSkill.SkillPreviewGraphic.sprite = skillLogic.SkillInformation.SkillSprite;
      }

      public void UpdateSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          skillLogic.SkillAttributes.SkillType.SetPreviewSkillCooldownGraphic(heroPreviewSkill);
      }
      
      public void UpdateSkillPreviewCooldownText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          var skillCooldown = skillLogic.SkillAttributes.BaseSkillCooldown;

          heroPreviewSkill.CooldownText.text = skillCooldown <= 0 ? " " : skillCooldown.ToString();
      }
      
      public void UpdateSkillPreviewSpeedText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          var skillSpeed = skillLogic.SkillAttributes.BaseSkillSpeed;

          heroPreviewSkill.SpeedText.text = skillSpeed <= 0 ? " " : skillSpeed.ToString();
      }
      
      public void UpdateSkillPreviewNameText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          var skillName = skillLogic.SkillInformation.SkillName;

          heroPreviewSkill.SkillNameText.text = skillName;
      }
      

      #endregion

      #endregion
   }
}
