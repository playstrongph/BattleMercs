namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IPlayerAsset
    {
        string PlayerName { get; }
        ITeamHeroesAsset PlayerHeroes { get; }
    }
}