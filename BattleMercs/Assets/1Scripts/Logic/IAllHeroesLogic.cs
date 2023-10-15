using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface IAllHeroesLogic
    {

        List<IHeroLogic> AllHeroes { get; }
        IBattleSceneLogicManager BattleSceneLogicManager { get; }
        Transform Transform { get; }

        void AddToAllHeroesList(GameObject heroLogicGameObject);



    }
}