using System.Collections.Generic;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IHeroAsset
    {
        string HeroName { get; }
        int HeroLevel { get; }
        int HeroStars { get; }
        int CumulativePower { get; }
        IHeroClassAsset HeroClass { get; }
        IHeroRaceAsset HeroRace { get; }
        int Health { get; }
        int Attack { get; }
        int Defense { get; }
        int Speed { get; }
        int Armor { get; }
        int FocusPoints { get; }
        int CriticalHitChance { get; }
        int CriticalHitDamage { get; }
        int Effectiveness { get; }
        int DualAttackChance { get; }
        int HitChance { get; }
        List<ISkillAsset> HeroSkills { get; }
    }
}