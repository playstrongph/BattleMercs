namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IPlayerAsset
    {
        string PlayerName { get; }
        int SoulsCount { get; }
        ITeamHeroesAsset PlayerHeroes { get; }
    }
}