using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IDisplaySkillTargetingVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        Transform CrossHair { get; }
        Transform Arrow { get; }
        List<Transform> Nodes { get; }
        Image CrossHairImage { get; }
        Image ArrowImage { get; }
        List<Image> NodesImage { get; }
    }
}