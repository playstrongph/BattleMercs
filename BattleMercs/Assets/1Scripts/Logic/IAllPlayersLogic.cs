using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IAllPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<IPlayerLogic> AllPlayers { get; }
    }
}