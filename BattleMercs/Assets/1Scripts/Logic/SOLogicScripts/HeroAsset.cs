using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "NewHeroAsset", menuName = "Assets/HeroAssets/NewHeroAsset")]
   public class HeroAsset : ScriptableObject, IHeroAsset
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [Header("Hero Information")]
      
      [SerializeField] private string heroName;
      [SerializeField] private int heroLevel;
      [SerializeField] private int heroStars;
      [SerializeField] private int cumulativePower;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private Object heroClass;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroRaceAsset))] private Object heroRace;

      [Header("Hero Attributes")] 
      [SerializeField] private int health;
      [SerializeField] private int attack;
      [SerializeField] private int defense;
      [SerializeField] private int speed;
      [SerializeField] private int armor;
      [SerializeField] private int focusPoints;
      [SerializeField] private int criticalHitChance;
      [SerializeField] private int criticalHitDamage;
      [SerializeField] private int effectiveness;
      [SerializeField] private int dualAttackChance;
      [SerializeField] private int hitChance;

      [Header("Hero Skills")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillAsset))] private List<Object> heroSkills = new List<Object>();
      
#pragma warning restore 0649

      #endregion

      #region PROPERTIES

      //Hero Information
      public string HeroName => heroName;
      public int HeroLevel => heroLevel;
      public int HeroStars => heroStars;
      public int CumulativePower => cumulativePower;
      public IHeroClassAsset HeroClass => heroClass as IHeroClassAsset;
      public IHeroRaceAsset HeroRace => heroRace as IHeroRaceAsset;
      
      //Hero Attributes
      public int Health => health;
      public int Attack => attack;
      public int Defense => defense;
      public int Speed => speed;
      public int Armor => armor;
      public int FocusPoints => focusPoints;
      public int CriticalHitChance => criticalHitChance;
      public int CriticalHitDamage => criticalHitDamage;
      public int Effectiveness => effectiveness;
      public int DualAttackChance => dualAttackChance;
      public int HitChance => hitChance;

      public List<ISkillAsset> HeroSkills
      {
          get
          {
              var newList = new List<ISkillAsset>();
              foreach (var heroSkill in heroSkills)
              {
                 newList.Add(heroSkill as ISkillAsset);
              }
              return newList;
          }
      }



      #endregion

      #region METHODS



      #endregion
   }
}
