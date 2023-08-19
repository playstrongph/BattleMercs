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
      

   }
}
