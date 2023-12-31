﻿using System.Collections.Generic;
using System.Text;
using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;


namespace _1Scripts.Logic
{
   public class InitializeAllHeroes : MonoBehaviour, IInitializeAllHeroes
   {
      #region VARIABLES
#pragma warning disable 0649

#pragma warning restore 0649

      #endregion

      #region PROPERTIES


      #endregion

      #region METHODS

      /// <summary>
      /// TEST
      /// </summary>
      /// <param name="logicManager"></param>
      /// <param name="playerLogic"></param>
      ///  /// <param name="playerHeroes"></param>
      public void LoadHeroes(IBattleSceneLogicManager logicManager, IPlayerLogic playerLogic, List<IHeroAsset> playerHeroes)
      {
          
          var heroLogicPrefab = logicManager.BattleSettings.HeroLogicPrefab;
          
      
              foreach (var heroAsset in playerHeroes)
              {
                  var newHero = Instantiate(heroLogicPrefab, playerLogic.Transform);
                  newHero.name = heroAsset.HeroName;
                  
                  var newHeroLogic = newHero.GetComponent<IHeroLogic>();

                  //Set Hero Information
                  SetHeroInformation(newHeroLogic,heroAsset);

                  //Set Hero Attributes
                  SetHeroAttributes(newHeroLogic, heroAsset);
                  
                  //Set the References
                  SetPlayerAndHeroReferences(newHeroLogic,playerLogic);

                  //Initialize Hero Skills
                  newHeroLogic.InitializeAllSkills.LoadAllSkills(logicManager,newHeroLogic,heroAsset);

              }//foreach heroAsset

      } //Load Heroes End
      
      
        
      /// <summary>
      /// Transfer the information parameters from the heroAsset to the heroLogic
      /// </summary>
      /// <param name="heroLogic"></param>
      /// <param name="heroAsset"></param>
      private void SetHeroInformation(IHeroLogic heroLogic, IHeroAsset heroAsset)
      {
          var heroInformation = heroLogic.HeroInformation;

          heroInformation.HeroName = heroAsset.HeroName;
          heroInformation.HeroLevel = heroAsset.HeroLevel;
          heroInformation.HeroStars = heroAsset.HeroStars;
          heroInformation.CumulativePower = heroAsset.CumulativePower;

          heroInformation.HeroElement = heroAsset.HeroElement;
          heroInformation.HeroClass = heroAsset.HeroClass;
          heroInformation.HeroZodiac = heroAsset.HeroZodiac;
          heroInformation.HeroGraphic = heroAsset.HeroSprite;
      }
      
      /// <summary>
      /// Transfer parameter values from hero asset to hero logic
      /// </summary>
      /// <param name="heroLogic"></param>
      /// <param name="heroAsset"></param>
      private void SetHeroAttributes(IHeroLogic heroLogic, IHeroAsset heroAsset)
      {
          var heroAttributes = heroLogic.HeroAttributes;
          
          
          //Initialize base attributes
          heroAttributes.BaseHealth = heroAsset.Health;
          heroAttributes.BaseAttack = heroAsset.Attack;
          heroAttributes.BaseDefense = heroAsset.Defense;
          heroAttributes.BaseSpeed = heroAsset.Speed;
          heroAttributes.BaseArmor = heroAsset.Armor;
          heroAttributes.BaseCriticalHitChance = heroAsset.CriticalHitChance;
          heroAttributes.BaseCriticalHitDamage = heroAsset.CriticalHitDamage;
          heroAttributes.BaseEffectiveness = heroAsset.Effectiveness;
          heroAttributes.BaseEffectResistance = heroAsset.EffectResistance;
          heroAttributes.BaseDualAttackChance = heroAsset.DualAttackChance;
          heroAttributes.BaseHitChance = heroAsset.HitChance;
          heroAttributes.BaseSpeedEnergy = heroAsset.SpeedEnergy;
          
          //Initialize attributes
          heroAttributes.Health = heroAsset.Health;
          heroAttributes.Attack = heroAsset.Attack;
          heroAttributes.Defense = heroAsset.Defense;
          heroAttributes.Speed = heroAsset.Speed;
          heroAttributes.Armor = heroAsset.Armor;
          heroAttributes.FocusPoints = heroAsset.FocusPoints;
          heroAttributes.CriticalHitChance = heroAsset.CriticalHitChance;
          heroAttributes.CriticalHitDamage = heroAsset.CriticalHitDamage;
          heroAttributes.Effectiveness = heroAsset.Effectiveness;
          heroAttributes.EffectResistance = heroAsset.EffectResistance;
          heroAttributes.DualAttackChance = heroAsset.DualAttackChance;
          heroAttributes.HitChance = heroAsset.HitChance;
          heroAttributes.SpeedEnergy = heroAsset.SpeedEnergy;

      }
      
      /// <summary>
      /// Set player and hero logic references
      /// </summary>
      /// <param name="heroLogic"></param>
      /// <param name="playerLogic"></param>
      private void SetPlayerAndHeroReferences(IHeroLogic heroLogic, IPlayerLogic playerLogic)
      {
          //Set Hero's PLayer Reference
          heroLogic.PlayerReference = playerLogic;
                  
          //Add to the player's PlayerHeroes and AliveHeroes list
          playerLogic.AddToPlayerHeroesList(heroLogic);
          playerLogic.AddToAliveHeroesList(heroLogic);
          
          //TODO: TEST Load Hero Visuals here
          
      }
      
      
      






      #endregion
   }
}
