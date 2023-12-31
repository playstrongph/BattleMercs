using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillTargetingVisual
    {

        ISkillVisual SkillVisualReference { get; set; }
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        IDraggable Draggable { get; }
        ISelectSkillTargetVisual SelectSkillTargetVisual { get; }
        IArrowLineAndCrossHairVisual ArrowLineAndCrossHairVisual { get; }
        Transform Arrow { get; }
        List<Transform> Nodes { get; }
        Image CrossHairImage { get; }
        Image ArrowImage { get; }
        List<Image> NodesImage { get; }
        Transform ThisTransform { get;}
        
        //TEST
        void StartTargeting(ISkillVisual skillVisual);
        void StopTargeting(ISkillVisual skillVisual);

        void ShowSkillTargetHeroGlows();


    }
}