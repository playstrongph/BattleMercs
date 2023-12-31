using System.Collections.Generic;
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

      public void LoadAllSkills(IBattleSceneLogicManager logicManager, IHeroLogic heroLogic, IHeroAsset heroAsset)
      {
         var skillAssets = heroAsset.HeroSkills;
         var skillLogicPrefab = logicManager.BattleSettings.SkillLogicPrefab;
         
         foreach (var skillAsset in skillAssets)
         {
            var newSkill = Instantiate(skillLogicPrefab, heroLogic.Transform);
            newSkill.name = skillAsset.SkillName;
            
            var newSkillLogic = newSkill.GetComponent<ISkillLogic>();
            
            //Set Skill Information
            SetSkillInformation(newSkillLogic,skillAsset);
            
            //Set Skill Attributes
            SetSkillAttributes(newSkillLogic,skillAsset);

            //Set References
            SetSkillAndHeroReferences(newSkillLogic, heroLogic);
         }
         
      } // Load Heroes
      
      /// <summary>
      /// Set skill information from skill asset
      /// </summary>
      /// <param name="skillLogic"></param>
      /// <param name="skillAsset"></param>
      private void SetSkillInformation(ISkillLogic skillLogic, ISkillAsset skillAsset)
      {
         var skillInformation = skillLogic.SkillInformation;

         skillInformation.SkillName = skillAsset.SkillName;
         skillInformation.SkillDescription = skillAsset.SkillDescription;
         skillInformation.SkillSprite = skillAsset.SkillSprite;
      }
      
      /// <summary>
      /// Set the skill attributes from the skill asset
      /// </summary>
      /// <param name="skillLogic"></param>
      /// <param name="skillAsset"></param>
      private void SetSkillAttributes(ISkillLogic skillLogic, ISkillAsset skillAsset)
      {
         var skillAttributes = skillLogic.SkillAttributes;

         skillAttributes.BaseSkillCooldown = skillAsset.BaseSkillCooldown;
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
         skillAttributes.SkillTarget = skillAsset.SkillTarget;
      }

      /// <summary>
      /// Set the skill and hero references
      /// </summary>
      /// <param name="skillLogic"></param>
      /// <param name="heroLogic"></param>
      private void SetSkillAndHeroReferences(ISkillLogic skillLogic, IHeroLogic heroLogic )
      {
         skillLogic.SkillInformation.CasterHero = heroLogic;
         heroLogic.AddToHeroSkillsList(skillLogic);
      }

      #endregion
   }
}
