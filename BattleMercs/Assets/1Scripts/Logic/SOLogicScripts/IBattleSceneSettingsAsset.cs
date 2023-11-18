using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IBattleSceneSettingsAsset
    {
        IPlayerAsset MainPlayer { get; }
        GameObject BattleSceneVisualManager { get; }
        GameObject BattleSceneLogicManager { get; }
        List<IPlayerAsset> AllEnemyPlayers { get; }
        GameObject PlayerLogicPrefab { get; }
        GameObject HeroLogicPrefab { get; }
        GameObject SkillLogicPrefab { get; }
    }
}