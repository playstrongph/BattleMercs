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
        void UpdateSkillPreviewGraphic(IHeroPreviewSkill heroPreviewSkill);
        void UpdateSkillPreviewCooldownGraphic(IHeroPreviewSkill heroPreviewSkill, ISkillVisual skillVisual);
        void UpdateSkillPreviewCooldownText(IHeroPreviewSkill heroPreviewSkill, ISkillVisual skillVisual);
        void UpdateSkillPreviewSpeedText(IHeroPreviewSkill heroPreviewSkill, ISkillVisual skillVisual);
        void UpdateSkillPreviewNameText(IHeroPreviewSkill heroPreviewSkill, ISkillVisual skillVisual);
        void UpdateSkillPreviewElementText(IHeroPreviewSkill heroPreviewSkill);
        void UpdateSkillPreviewDescriptionText(IHeroPreviewSkill heroPreviewSkill, ISkillVisual skillVisual);
        

    }
}