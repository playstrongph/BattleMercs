﻿using System.Collections.Generic;
using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
    public interface IHeroPreviewVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        IHeroPreviewHero HeroPreviewHero { get; }
        List<IHeroPreviewSkill> HeroPreviewSkillList { get; }

        //IHeroLogic HeroLogicReference { get; set; }

        IHeroVisual HeroVisualReference { get;}

        ISetPreviewHeroComponents SetPreviewHeroComponents { get; }

        Transform ThisTransform { get; }
        void ShowHeroPreviewVisual(IHeroVisual heroVisual);

        void HideHeroPreviewVisual();
    }
}