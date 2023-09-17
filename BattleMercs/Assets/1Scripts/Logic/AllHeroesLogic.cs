using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using Object = UnityEngine.Object;


namespace _1Scripts.Logic
{
   public class AllHeroesLogic : MonoBehaviour, IAllHeroesLogic
   {

      #region VARIABLES
#pragma warning disable 0649
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;

      [SerializeField] private List<HeroLogic> allHeroes = new List<HeroLogic>();

#pragma warning restore 0649

      #endregion
      
      #region PROPERTIES
      
      public List<IHeroLogic> AllHeroes
      {
         get
         {
            var newList = new List<IHeroLogic>();
            foreach (var hero in allHeroes)
            {
               newList.Add(hero);
            }
            return newList;
         }
      }
      public IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;

      #endregion


      #region STRUCTS
      
      /// <summary>
      /// This is effectively the heroLogic Information
      /// </summary>

      [Serializable]
      public struct HeroLogic : IHeroLogic
      {
         #region StructVariables
         
         #pragma warning disable 0649
         
         //This is for changing the list element name only
         [SerializeField] private string heroNameLabel;
         [SerializeField] private HeroInformationStruct heroInformation;
         [SerializeField] private HeroAttributesStruct heroAttributes;

         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillLogic))] private List<Object> heroSkills;


         #pragma warning restore 0649

         #endregion

         #region StructProperties

         public string HeroNameLabel { get => heroNameLabel; set => heroNameLabel = value; }
         public IHeroInformation HeroInformation => heroInformation;
         public IHeroAttributes HeroAttributes => heroAttributes;

         public List<ISkillLogic> HeroSkills
         {
            get
            {
               var newList = new List<ISkillLogic>();
               foreach (var heroSKill in heroSkills)
               {
                  newList.Add(heroSKill as ISkillLogic);
               }
               return newList;
            }
            
            
         }



         #endregion
      }
      
      [Serializable]
      public struct HeroInformationStruct : IHeroInformation 
      {
         #region StructVariables
         
         #pragma warning disable 0649
         
         //[Header("Hero Information")]
         [SerializeField] private string heroName;
         [SerializeField] private int heroLevel;
         [SerializeField] private int heroStars;
         [SerializeField] private int heroCp;

         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private Object heroClass;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroZodiacAsset))] private Object heroRace;

         #pragma warning restore 0649 
         #endregion

         #region StructProperties

         public string HeroName => heroName;
         public int HeroLevel => heroLevel;
         public int HeroStars => heroStars;
         public int HeroCp => heroCp;
         
         public IHeroClassAsset HeroClass => heroClass as IHeroClassAsset;
         public IHeroZodiacAsset HeroZodiac => heroRace as IHeroZodiacAsset;

         #endregion
      }
      
      [Serializable]
      public struct HeroAttributesStruct: IHeroAttributes
      {
         //Variables
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
         [SerializeField] private int dualAttackChance;
         [SerializeField] private int hitChance;
         
         #pragma warning disable 0649
         
         //Properties

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

         

         
      }
      
     
      

      #endregion
        
      
      #region METHODS

      


      #endregion
   }
}
