using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IBattleSceneLogicManager
    {
        //Prefabs
        GameObject PrefabBattleSceneManagerVisual { get; }
        
        //Components
        IAllPlayersLogic AllPlayersLogic { get; }
        IAllHeroesLogic AllHeroesLogic { get; }

        IAllSkillsLogic AllSkillsLogic { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; set; }
    }
}