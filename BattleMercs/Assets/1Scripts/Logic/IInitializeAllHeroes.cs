using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
    public interface IInitializeAllHeroes
    {
        void LoadHeroes(IBattleSceneLogicManager logicManager, IPlayerLogic playerLogic, List<IHeroAsset> playerHeroes);
    }
}