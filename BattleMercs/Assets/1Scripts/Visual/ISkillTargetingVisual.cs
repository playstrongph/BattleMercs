using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillTargetingVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        IDraggable Draggable { get; }
        ISelectSkillTargetVisual SelectSkillTargetVisual { get; }
        Transform CrossHair { get; }
        Transform Arrow { get; }
        List<Transform> Nodes { get; }
        Image CrossHairImage { get; }
        Image ArrowImage { get; }
        List<Image> NodesImage { get; }
        Transform ThisTransform { get; set; }
    }
}