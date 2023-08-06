using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IBattleSceneLogicManager
    {
        GameObject PrefabBattleSceneManagerVisual { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get;}

        GameObject SetBattleSceneManagerVisual { set; }
        
        //Components
        IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual { get; }
    }
}