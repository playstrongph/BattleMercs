﻿using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillTypeAsset
    {
        void StartSkillTargetingVisual(ISkillVisual skillVisual, ISelectSkillTargetVisual selectSkillTargetVisual);

        void SetPreviewSkillCooldownGraphic(IHeroPreviewSkill heroPreviewSkill);
    }
}