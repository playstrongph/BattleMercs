using _1Scripts.Logic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ISetPreviewHeroComponents
    {
        //HERO PREVIEW HERO
        void UpdateHeroPreviewHeroGraphic(Sprite heroGraphic);
        void UpdateHeroPreviewGameObjectName(string heroName);
        void UpdateHeroPreviewFrame(IHeroElementAsset heroElement);
        void UpdateHeroPreviewAttackText(int attackValue);
        void UpdateHeroPreviewHealthText(int healthValue);
        void UpdateHeroPreviewArmorText(int armorValue);
        void UpdateHeroPreviewNameText(string heroName);
        void UpdateHeroPreviewClassText(string heroClassName);
        
        //HERO PREVIEW SKILL
        void UpdateHeroPreviewSkillFrame(IHeroPreviewSkill heroPreviewSkill, IHeroElementAsset heroElement);
        void UpdateSkillPreviewGraphic(IHeroPreviewSkill heroPreviewSkill, Sprite skillPreviewSprite);
        void UpdateSkillPreviewElementText(IHeroPreviewSkill heroPreviewSkill, IHeroElementAsset heroElementAsset);
        void UpdateSkillPreviewDescriptionText(IHeroPreviewSkill heroPreviewSkill, string skillDescription);
        void UpdateSkillPreviewCooldownText(IHeroPreviewSkill heroPreviewSkill, ISkillTypeAsset skillType, int currentSkillCooldown);
        void UpdateSkillPreviewSpeedText(IHeroPreviewSkill heroPreviewSkill, int baseSkillSpeed);
        void UpdateSkillPreviewNameText(IHeroPreviewSkill heroPreviewSkill, string skillName);
        
        //void EnableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        //void DisableSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);


    }
}