namespace _1Scripts.Visual
{
    public interface IBattleSceneManagerVisual
    {
        //Inspector References
        IGameBoardVisual GameBoardVisual { get; }
        IPlayerVisual MainPlayerVisual { get; }
        IPlayerVisual EnemyPlayerVisual { get; }
    }
}