

namespace _1Scripts.Logic
{
   public interface IHeroAttributes
   {
      int Health { get; set; }
      int Attack { get; set; }
      int Defense { get; set; }
      int Speed { get; set; }
      int Armor { get; set; }
      int FocusPoints { get; set; }
      int CriticalHitChance { get; set; }
      int CriticalHitDamage { get; set;}
      int Effectiveness { get; set; }
      int EffectResistance { get; set; }
      int DualAttackChance { get; set; }
      int HitChance { get; set; }
      int SpeedEnergy { get; set; }

      //BASE ATTRIBUTES
      int BaseHealth { get; set; }
      int BaseAttack { get; set; }
      int BaseDefense { get; set; }
      int BaseSpeed { get; set; }
      int BaseArmor { get; set; }
      int BaseCriticalHitChance { get; set; }
      int BaseCriticalHitDamage { get; set;}
      int BaseEffectiveness { get; set; }
      int BaseEffectResistance { get; set; }
      int BaseDualAttackChance { get; set; }
      int BaseHitChance { get; set; }
      
      int BaseSpeedEnergy { get; set; }
   }
}
