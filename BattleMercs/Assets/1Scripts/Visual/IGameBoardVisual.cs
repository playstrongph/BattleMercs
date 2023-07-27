using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface IGameBoardVisual
    {
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        Canvas Canvas { get; }
        Image Image { get; }
    }
}