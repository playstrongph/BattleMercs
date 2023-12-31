﻿using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillReadinessAsset
    {
        void StartSkillTargetingVisual(ISkillVisual skillVisual,ISelectSkillTargetVisual selectSkillTargetVisual);

        void UpdateSkillReadinessVisual(ISkillVisual skillVisual);
    }
}