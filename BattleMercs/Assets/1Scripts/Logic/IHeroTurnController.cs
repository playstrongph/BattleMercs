namespace _1Scripts.Logic
{
    public interface IHeroTurnController
    {
        /// <summary>
        /// hero currently taking a turn
        /// </summary>
        IHeroLogic ActiveTurnHero { get; }

        /// <summary>
        /// 
        /// </summary>
        void UpdateNextActiveHero();

        int SpeedEnergyTurnLimit { get; }
    }
}