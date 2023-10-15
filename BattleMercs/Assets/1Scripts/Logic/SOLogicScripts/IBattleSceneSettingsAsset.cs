using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IBattleSceneSettingsAsset
    {
        List<IPlayerAsset> AllPlayers { get; }

        GameObject PlayerLogicPrefab { get; }

        GameObject HeroLogicPrefab { get; }
    }
}