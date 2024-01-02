using UnityEngine;

namespace _1Scripts.Logic
{
   public class HeroAttributes : MonoBehaviour, IHeroAttributes
   {
      #region VARIABLES
      
#pragma warning disable 0649
       
      [Header("ATTRIBUTES")]
      [SerializeField] private int health;
      [SerializeField] private int attack;
      [SerializeField] private int defense;
      [SerializeField] private int speed;
      [SerializeField] private int armor;
      [SerializeField] private int criticalHitChance;
      [SerializeField] private int criticalHitDamage;
      [SerializeField] private int effectiveness;
      [SerializeField] private int effectResistance;
      [SerializeField] private int dualAttackChance;
      [SerializeField] private int hitChance;
      [SerializeField] private int focusPoints;
      [SerializeField] private int speedEnergy;
      
      
      [Header("BASE ATTRIBUTES")]
      [SerializeField] private int baseHealth;
      [SerializeField] private int baseAttack;
      [SerializeField] private int baseDefense;
      [SerializeField] private int baseSpeed;
      [SerializeField] private int baseArmor;
      [SerializeField] private int baseCriticalHitChance;
      [SerializeField] private int baseCriticalHitDamage;
      [SerializeField] private int baseEffectiveness;
      [SerializeField] private int baseEffectResistance;
      [SerializeField] private int baseDualAttackChance;
      [SerializeField] private int baseHitChance;
      [SerializeField] private int baseSpeedEnergy;
         
#pragma warning disable 0649
        

      #endregion
        
      #region PROPERTIES
      
      //ATTRIBUTES
      public int Health { get => health; set => health = value; }
      public int Attack { get => attack; set => attack = value; }
      public int Defense { get => defense; set => defense = value; }
      public int Speed { get => speed; set => speed = value; }
      public int Armor { get => armor; set => armor = value; }
      public int CriticalHitChance { get => criticalHitChance; set => criticalHitChance = value; }
      public int CriticalHitDamage { get => criticalHitDamage; set => criticalHitDamage = value; }
      public int Effectiveness { get => effectiveness; set => effectiveness = value; }
      public int EffectResistance { get => effectResistance; set => effectResistance = value; }
      public int DualAttackChance { get => dualAttackChance; set => dualAttackChance = value; }
      public int HitChance { get => hitChance; set => hitChance = value; }
      public int FocusPoints { get => focusPoints; set => focusPoints = value; }
      public int SpeedEnergy { get => speedEnergy; set => speedEnergy = value; }
      
      //BASE ATTRIBUTES
      
      public int BaseHealth { get => baseHealth; set => baseHealth = value; }
      public int BaseAttack { get => baseAttack; set => baseAttack = value; }
      public int BaseDefense { get => baseDefense; set => baseDefense = value; }
      public int BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
      public int BaseArmor { get => baseArmor; set => baseArmor = value; }
      public int BaseCriticalHitChance { get => baseCriticalHitChance; set => baseCriticalHitChance = value; }
      public int BaseCriticalHitDamage { get => baseCriticalHitDamage; set => baseCriticalHitDamage = value; }
      public int BaseEffectiveness { get => baseEffectiveness; set => baseEffectiveness = value; }
      public int BaseEffectResistance { get => baseEffectResistance; set => baseEffectResistance = value; }
      public int BaseDualAttackChance { get => baseDualAttackChance; set => baseDualAttackChance = value; }
      public int BaseHitChance { get => baseHitChance; set => baseHitChance = value; }
      public int BaseSpeedEnergy { get => baseSpeedEnergy; set => baseSpeedEnergy = value; }
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
