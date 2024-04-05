using _1Scripts.Logic;
using _1Scripts.Logic.SOLogicScripts;
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

      public void UpdateHeroPreviewGameObjectName(string heroName)
      {
          HeroPreviewVisual.ThisTransform.gameObject.name = heroName + "HeroPreview";
      }
      
      public void UpdateHeroPreviewHeroGraphic(Sprite heroGraphic)
      {
          HeroPreviewVisual.HeroPreviewHero.HeroGraphic.sprite = heroGraphic;
      }

      public void UpdateHeroPreviewFrame(IHeroElementAsset heroElement)
      {
          heroElement.SetHeroPreviewClassColor(HeroPreviewVisual);
      }
      
      public void UpdateHeroPreviewAttackText(int attackValue)
      {
          HeroPreviewVisual.HeroPreviewHero.AttackText.text = attackValue.ToString();
      }
      
      public void UpdateHeroPreviewHealthText(int healthValue)
      {
          HeroPreviewVisual.HeroPreviewHero.HealthText.text = healthValue.ToString();
      }

      public void UpdateHeroPreviewArmorText(int armorValue)
      {
          HeroPreviewVisual.HeroPreviewHero.ArmorText.text = armorValue.ToString();

          //Hide Armor image if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.Armor.enabled = armorValue > 0;
          
          //Hide Armor text if armor is less than or equal to zero
          HeroPreviewVisual.HeroPreviewHero.ArmorText.enabled = armorValue > 0;
      }
      
      public void UpdateHeroPreviewNameText(string heroName)
      {
          HeroPreviewVisual.HeroPreviewHero.NameText.text = heroName;
      }
      
      public void UpdateHeroPreviewClassText(string heroClassName)
      {

          HeroPreviewVisual.HeroPreviewHero.ClassText.text = heroClassName;
      }
      
      #endregion

      #region HeroPreviewSkill Updates

      public void UpdateHeroPreviewSkillFrame(IHeroPreviewSkill heroPreviewSkill, IHeroElementAsset heroElement)
      {
          heroElement.SetHeroPreviewSkillClassColor(heroPreviewSkill);
      }
      
      public void UpdateSkillPreviewElementText(IHeroPreviewSkill heroPreviewSkill, IHeroElementAsset heroElementAsset)
      {
          heroElementAsset.SetHeroPreviewElementText(heroPreviewSkill);
      }
      
      public void UpdateSkillPreviewDescriptionText(IHeroPreviewSkill heroPreviewSkill, string skillDescription)
      {
          heroPreviewSkill.SkillDescriptionText.text = skillDescription;
      }
      
      public void UpdateSkillPreviewGraphic(IHeroPreviewSkill heroPreviewSkill, Sprite skillPreviewSprite)
      {
          heroPreviewSkill.SkillPreviewGraphic.sprite = skillPreviewSprite;
      }

      public void UpdateSkillPreviewCooldownText(IHeroPreviewSkill heroPreviewSkill, ISkillTypeAsset skillType, int currentSkillCooldown)
      {
          if (currentSkillCooldown <= 0)
          {
              skillType.DisableSkillPreviewCooldownGraphic(heroPreviewSkill);
              
          }
          else
          {
              skillType.EnableSkillPreviewCooldownGraphic(heroPreviewSkill);
              heroPreviewSkill.CooldownText.text = currentSkillCooldown.ToString();
          }
      }
      
      public void UpdateSkillPreviewSpeedText(IHeroPreviewSkill heroPreviewSkill, int baseSkillSpeed)
      {
          heroPreviewSkill.SpeedText.text = baseSkillSpeed <= 0 ? " " : baseSkillSpeed.ToString();
      }
      
      public void UpdateSkillPreviewNameText(IHeroPreviewSkill heroPreviewSkill, string skillName)
      {
          heroPreviewSkill.SkillNameText.text = skillName;
      }
      
      /*public void EnableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          skillLogic.SkillAttributes.SkillType.EnableSkillPreviewCooldownGraphic(heroPreviewSkill);
      }
      
      public void DisableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic)
      {
          skillLogic.SkillAttributes.SkillType.DisableSkillPreviewCooldownGraphic(heroPreviewSkill);
      }*/
      

      #endregion

      #endregion
   }
}
