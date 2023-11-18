using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IBattleSceneLogicManager
    {
        //Components

        IBattleSceneSettingsAsset BattleSettings { get; }
        IAllPlayersLogic AllPlayersLogic { get; }
        IBattleSceneVisualManager BattleSceneVisualManager { get; set; }
        Transform Transform { get; }

        //Attached Components
        IInitializeAllPlayers InitializeAllPlayers { get; }
        IUniqueIDGenerator UniqueIDGenerator { get; }

        IBattleStart BattleStart { get; }


    }
}