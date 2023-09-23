using UnityEngine;

namespace _1Scripts.Logic
{
   public interface IHeroAttributes
   {
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
   }
}
