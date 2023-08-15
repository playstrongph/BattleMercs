using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<PlayersLogic.PlayersStruct> AllPlayers { get; }
    }
}