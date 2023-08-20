using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IBattleSceneLogicManager
    {
        //Prefabs
        GameObject PrefabBattleSceneManagerVisual { get; }
        
        //Components
        IPlayersLogic PlayersLogic { get; }
        IAllHeroesLogic AllHeroesLogic { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; set; }
    }
}