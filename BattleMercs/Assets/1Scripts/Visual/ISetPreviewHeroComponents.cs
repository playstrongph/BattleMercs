using _1Scripts.Logic;

namespace _1Scripts.Visual
{
    public interface ISetPreviewHeroComponents
    {
        //HERO PREVIEW HERO
        void UpdateHeroPreviewHeroGraphic();
        void UpdateHeroPreviewGameObjectName();
        void UpdateHeroPreviewFrame();
        void UpdateHeroPreviewAttackText();
        void UpdateHeroPreviewHealthText();
        void UpdateHeroPreviewArmorText();
        void UpdateHeroPreviewNameText();
        void UpdateHeroPreviewClassText();
        
        //HERO PREVIEW SKILL
        void UpdateHeroPreviewSkillFrame(IHeroPreviewSkill heroPreviewSkill);
        void UpdateSkillPreviewGraphic(IHeroPreviewSkill heroPreviewSkill,ISkillLogic skillLogic);
        
        void UpdateSkillPreviewElementText(IHeroPreviewSkill heroPreviewSkill);
        void UpdateSkillPreviewDescriptionText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        void UpdateSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        void UpdateSkillPreviewCooldownText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        void UpdateSkillPreviewSpeedText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        void UpdateSkillPreviewNameText(IHeroPreviewSkill heroPreviewSkill, ISkillLogic skillLogic);
        

    }
}