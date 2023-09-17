using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IHeroAsset
    {
        string HeroName { get; }
        int HeroLevel { get; }
        int HeroStars { get; }
        int CumulativePower { get; }
        IHeroElementAsset HeroElement { get; }
        IHeroClassAsset HeroClass { get; }
        IHeroZodiacAsset HeroZodiac { get; }
        
        
        Sprite HeroSprite { get; }


        int Health { get; }
        int Attack { get; }
        int Defense { get; }
        int Speed { get; }
        int Armor { get; }
        int FocusPoints { get; }
        int CriticalHitChance { get; }
        int CriticalHitDamage { get; }
        int Effectiveness { get; }
        int EffectResistance { get; }
        int DualAttackChance { get; }
        int HitChance { get; }
        List<ISkillAsset> HeroSkills { get; }
    }
}