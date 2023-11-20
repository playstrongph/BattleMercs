using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IAllPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }

        GameObject MainPlayer { get; set; }

        GameObject SelectedEnemyPlayer { get; set; }

        List<IPlayerLogic> AllEnemyPlayers { get; }

        Transform Transform { get; }

        void AddToAllPlayersList(GameObject playerLogicGameObject);
        
        
    }
}