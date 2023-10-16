using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class InitializeAllSkills : MonoBehaviour, IInitializeAllSkills
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public void LoadAllSkills(IBattleSceneLogicManager logicManager)
      {
         var allPlayerAssets = logicManager.BattleSettings.AllPlayers;
         var allSkillsLogic = logicManager.AllSkillsLogic;
         var skillLogicPrefab = logicManager.BattleSettings.SkillLogicPrefab;

         foreach (var playerAsset in allPlayerAssets)
         {
            var heroAssets = playerAsset.PlayerHeroes.TeamHeroes;
            
            foreach (var heroAsset in heroAssets)
            {
               var skillAssets = heroAsset.HeroSkills;

               foreach (var skillAsset in skillAssets)
               {
                  var newSkill = Instantiate(skillLogicPrefab,allSkillsLogic.Transform);
                  newSkill.name = skillAsset.SkillName;

                  var newSkillLogic = newSkill.GetComponent<ISkillLogic>();
                  
                  //TODO: Set Skill Information
                  SetSkillInformation(newSkillLogic,skillAsset);
                  
                  //TODO: Set Hero Attributes
                  SetSkillAttributes(newSkillLogic,skillAsset);
                  
                  //TODO: Add to All Skills List
                 allSkillsLogic.AddToAllSkillsList(newSkillLogic);

               }
               
               
            }
         }
      } // Load Heroes


      private void SetSkillInformation(ISkillLogic skillLogic, ISkillAsset skillAsset)
      {
         var skillInformation = skillLogic.SkillInformation;

         skillInformation.SkillName = skillAsset.SkillName;
         skillInformation.SkillDescription = skillAsset.SkillDescription;
         skillInformation.SkillSprite = skillAsset.SkillSprite;
      }
      
      private void SetSkillAttributes(ISkillLogic skillLogic, ISkillAsset skillAsset)
      {
         var skillAttributes = skillLogic.SkillAttributes;

         skillAttributes.BaseSkillCooldown = skillAsset.BaseSkillSpeed;
         skillAttributes.BaseSkillSpeed = skillAsset.BaseSkillSpeed;
         skillAttributes.SkillFightingSpirit = skillAsset.SkillFightingSpirit;
         skillAttributes.SkillFocusPoints = skillAsset.SkillFocusPoints;
         skillAttributes.SkillStackingCounters = skillAsset.SkillStackingCounters;
         skillAttributes.FightingSpiritCost = skillAsset.FightingSpiritCost;
         skillAttributes.FocusPointsCost = skillAsset.FocusPointsCost;
         skillAttributes.StackingCountersLimit = skillAsset.StackingCountersLimit;

         skillAttributes.SkillElementAsset = skillAsset.SkillElement;
         skillAttributes.SkillType = skillAsset.SkillType;
         skillAttributes.SkillReadiness = skillAsset.SkillReadiness;
         skillAttributes.SkillEnableStatus = skillAsset.SkillEnableStatus;
         skillAttributes.SkillTargetAsset = skillAsset.SkillTarget;
      }

      #endregion
   }
}
