using UnityEngine;

namespace _1Scripts.Logic
{
   public class HeroAttributes : MonoBehaviour, IHeroAttributes
   {
      #region VARIABLES
      
#pragma warning disable 0649

      [SerializeField] private int health;
      [SerializeField] private int attack;
      [SerializeField] private int defense;
      [SerializeField] private int speed;
      [SerializeField] private int armor;
      [SerializeField] private int focusPoints;
      [SerializeField] private int criticalHitChance;
      [SerializeField] private int criticalHitDamage;
      [SerializeField] private int effectiveness;
      [SerializeField] private int effectResistance;
      [SerializeField] private int dualAttackChance;
      [SerializeField] private int hitChance;
         
#pragma warning disable 0649
        

      #endregion
        
      #region PROPERTIES

      public int Health { get => health; set => health = value; }
      public int Attack { get => attack; set => attack = value; }
      public int Defense { get => defense; set => defense = value; }
      public int Speed { get => speed; set => speed = value; }
      public int Armor { get => armor; set => armor = value; }
      public int FocusPoints { get => focusPoints; set => focusPoints = value; }
      public int CriticalHitChance { get => criticalHitChance; set => criticalHitChance = value; }
      public int CriticalHitDamage { get => criticalHitDamage; set => criticalHitDamage = value; }
      public int Effectiveness { get => effectiveness; set => effectiveness = value; }
      public int EffectResistance { get => effectResistance; set => effectResistance = value; }
      public int DualAttackChance { get => dualAttackChance; set => dualAttackChance = value; }
      public int HitChance { get => hitChance; set => hitChance = value; }
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
