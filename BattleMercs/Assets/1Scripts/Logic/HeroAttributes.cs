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
      
      public int Health => health;
      public int Attack => attack;
      public int Defense => defense;
      public int Speed => speed;
      public int Armor => armor;
      public int FocusPoints => focusPoints;
      public int CriticalHitChance => criticalHitChance;
      public int CriticalHitDamage => criticalHitDamage;
      public int Effectiveness => effectiveness;
      public int EffectResistance => effectResistance;
      public int DualAttackChance => dualAttackChance;
      public int HitChance => hitChance;
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
