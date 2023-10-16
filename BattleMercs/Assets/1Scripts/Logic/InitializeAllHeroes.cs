using System.Collections.Generic;
using System.Text;
using _1Scripts.Logic.SOLogicScripts;
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
      
      public void LoadHeroes(IBattleSceneLogicManager logicManager)
      {
          var allPlayerAssets = logicManager.BattleSettings.AllPlayers;
          var allHeroesLogic = logicManager.AllHeroesLogic;
          var heroLogicPrefab = logicManager.BattleSettings.HeroLogicPrefab;


          foreach (var playerAsset in allPlayerAssets)
          {
              var heroAssets = playerAsset.PlayerHeroes.TeamHeroes;

              foreach (var heroAsset in heroAssets)
              {
                  var newHero = Instantiate(heroLogicPrefab, allHeroesLogic.Transform);
                  newHero.name = heroAsset.HeroName;
                  
                  var newHeroLogic = newHero.GetComponent<IHeroLogic>();
                  
                  //Set Hero Information
                  SetHeroInformation(newHeroLogic,heroAsset);

                  //Set Hero Attributes
                  SetHeroAttributes(newHeroLogic, heroAsset);
                  
                  //Add to all heroes list
                  allHeroesLogic.AddToAllHeroesList(newHero);

              }//foreach heroAsset
          }//foreach playerAsset
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
      }
      
      /// <summary>
      /// Transfer parameter values from hero asset to hero logic
      /// </summary>
      /// <param name="heroLogic"></param>
      /// <param name="heroAsset"></param>
      private void SetHeroAttributes(IHeroLogic heroLogic, IHeroAsset heroAsset)
      {
          var heroAttributes = heroLogic.HeroAttributes;

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
      }
      
      




      #endregion
   }
}
