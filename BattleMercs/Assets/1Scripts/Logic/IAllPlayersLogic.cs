using System.Collections.Generic;

namespace _1Scripts.Logic
{
    public interface IAllPlayersLogic
    {
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        List<AllPlayersLogic.PlayerLogic> AllPlayers { get; }
    }
}