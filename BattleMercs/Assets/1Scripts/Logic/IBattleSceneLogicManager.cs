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
        IAllHeroesLogic AllHeroesLogic { get; }

        IAllSkillsLogic AllSkillsLogic { get; }

        IInitializeAllSkills InitializeAllSkills { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; set; }
        
        //Attached Components
        IInitializeAllPlayers InitializeAllPlayers { get; }
        IInitializeAllHeroes InitializeAllHeroes { get; }
        IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual { get; }
        IUniqueIDGenerator UniqueIDGenerator { get; }
    }
}