using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IBattleSceneSettingsAsset
    {
        IPlayerAsset MainPlayer { get; }
        List<IPlayerAsset> AllEnemyPlayers { get; }
        IPlayerAllianceAsset AllyPlayerAlliance { get; }
        IPlayerAllianceAsset EnemyPlayerAlliance { get; }
        GameObject PlayerLogicPrefab { get; }
        GameObject HeroLogicPrefab { get; }
        GameObject SkillLogicPrefab { get; }
    }
}