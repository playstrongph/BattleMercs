using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
    public interface IAllPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<IPlayerLogic> AllPlayers { get; }
        
        void AddNewPlayers(List<IPlayerAsset> playerAssets);
    }
}