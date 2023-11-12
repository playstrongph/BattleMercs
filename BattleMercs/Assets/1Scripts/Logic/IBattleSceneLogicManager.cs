using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IBattleSceneLogicManager
    {
        //Prefabs
        GameObject PrefabBattleSceneManagerVisual { get; }
        
        //Components

        IBattleSceneSettingsAsset BattleSettings { get; }
        IAllPlayersLogic AllPlayersLogic { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; set; }
        Transform Transform { get; }

        //Attached Components
        IInitializeAllPlayers InitializeAllPlayers { get; }
        IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual { get; }
        IUniqueIDGenerator UniqueIDGenerator { get; }
        

    }
}