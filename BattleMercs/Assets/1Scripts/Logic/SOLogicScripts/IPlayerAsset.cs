using System.Collections.Generic;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IPlayerAsset
    {
        string PlayerName { get; }
        int SoulsCount { get; }
        List<IHeroAsset> Heroes { get; }
        void AddToHeroesList(IHeroAsset heroAsset);
    }
}