using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IGameBoardVisual
    {
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        Canvas Canvas { get; }
        Image Image { get; }
    }
}