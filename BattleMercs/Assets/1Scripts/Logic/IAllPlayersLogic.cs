﻿using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IAllPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<IPlayerLogic> OldAllPlayers { get; }
        
        List<IPlayerLogic> AllPlayers { get; }

        void AddNewPlayers(List<IPlayerAsset> playerAssets);

        Transform Transform { get; }

        void AddToAllPlayersList(GameObject playerLogicGameObject);
    }
}