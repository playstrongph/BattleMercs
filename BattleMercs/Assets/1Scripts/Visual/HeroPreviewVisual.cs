using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class HeroPreviewVisual : MonoBehaviour, IHeroPreviewVisual
   {
      #region VARIABLES
#pragma warning disable 0649
      [Header("Runtime Set References")]
      //[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogicReference = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisualReference;

      [Header("Components")] 
      [SerializeField] private Canvas canvas;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewHero))] private Object heroPreviewHero;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewSkill))] private List<Object> heroPreviewSkillList = new List<Object>();

      [Header("Inspector Set References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetPreviewHeroComponents))] private Object setPreviewHeroComponents;

      [Header("Preview Parameters")] 
      [SerializeField] private float displayDelay = 0.5f;
      [SerializeField] private bool enablePreview = false;
      
      
      //Private Variables
      private Coroutine _delayCoroutine;
      
    
#pragma warning restore 0649
      
      
      
      #endregion

      #region PROPERTIES
      
      //Runtime References
     
      
      public IHeroVisual HeroVisualReference
      {
         get => heroVisualReference as IHeroVisual;
         private set => heroVisualReference = value as Object;
      }

      //Inspector References
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;
      
      //Components
      private Canvas Canvas => canvas;
      public IHeroPreviewHero HeroPreviewHero => heroPreviewHero as IHeroPreviewHero;

      public List<IHeroPreviewSkill> HeroPreviewSkillList
      {
         get
         {
            var newList = new List<IHeroPreviewSkill>();
            foreach (var heroPreviewSkill in heroPreviewSkillList)
            {
               newList.Add(heroPreviewSkill as IHeroPreviewSkill);
            }
            return newList;
         }
      }

      public ISetPreviewHeroComponents SetPreviewHeroComponents => setPreviewHeroComponents as ISetPreviewHeroComponents;

      public Transform ThisTransform => transform;


      #endregion

      #region METHODS
      
      
      
      public void ShowHeroPreviewVisual(IHeroVisual heroVisual)
      {
         enablePreview = true;
         
         if(_delayCoroutine != null)StopCoroutine(_delayCoroutine);

         _delayCoroutine = StartCoroutine(UpdateHeroPreviewCoroutine(heroVisual));
      }
      
      public void HideHeroPreviewVisual()
      {
         enablePreview = false;
         Canvas.enabled = false;
         
         if(_delayCoroutine != null)StopCoroutine(_delayCoroutine);
      }

      private IEnumerator UpdateHeroPreviewCoroutine(IHeroVisual heroVisual)
      {

         yield return new WaitForSeconds(displayDelay);

         if (enablePreview)
         {
            UpdateAllHeroPreviewHeroVisualComponents(heroVisual);
            Canvas.enabled = true;
         }

         _delayCoroutine = null;
      }

      /// <summary>
      /// Updates all of the components and sets the heroLogic reference
      /// </summary>
      /// <param name="heroVisual"></param>
      private void UpdateAllHeroPreviewHeroVisualComponents(IHeroVisual heroVisual)
      {
         
         var heroSkillsCount = heroVisual.HeroLogicReference.HeroSkillsReference.Count;
         
         //Set References
         HeroVisualReference = heroVisual;
         
         //HeroLogic Reference
         var heroLogicReference = HeroVisualReference.HeroLogicReference;
         
         //Information and Attributes
         var heroName = heroLogicReference.HeroInformation.HeroName;
         var heroGraphic = heroLogicReference.HeroInformation.HeroGraphic;
         var heroElement = heroLogicReference.HeroInformation.HeroElement;
         var heroAttackValue = heroLogicReference.HeroAttributes.Attack;
         var heroHealthValue = heroLogicReference.HeroAttributes.Health;
         var heroArmorValue = heroLogicReference.HeroAttributes.Armor;
         var heroClassName = heroLogicReference.HeroInformation.HeroClass.ClassName;

         //Change the HeroPreviewVisual Hero Object Name
         SetPreviewHeroComponents.UpdateHeroPreviewGameObjectName(heroName);
         
         //Update the hero preview hero components
         SetPreviewHeroComponents.UpdateHeroPreviewHeroGraphic(heroGraphic);
         SetPreviewHeroComponents.UpdateHeroPreviewFrame(heroElement);
         SetPreviewHeroComponents.UpdateHeroPreviewAttackText(heroAttackValue);
         SetPreviewHeroComponents.UpdateHeroPreviewHealthText(heroHealthValue);
         SetPreviewHeroComponents.UpdateHeroPreviewArmorText(heroArmorValue);
         SetPreviewHeroComponents.UpdateHeroPreviewNameText(heroName);
         SetPreviewHeroComponents.UpdateHeroPreviewClassText(heroClassName);
         
         //Created to disable the 4th++ skills without needing if statements
         for (var i = 0; i < heroPreviewSkillList.Count; i++)
         {
            var heroPreviewSkill = HeroPreviewSkillList[i];
            
            heroPreviewSkill.Transform.gameObject.SetActive(false);
         }

         //Update the hero preview skills 
        for (var i = 0; i < heroSkillsCount; i++)
         {
            var heroPreviewSkill = HeroPreviewSkillList[i];
            var skillLogic = heroVisual.HeroLogicReference.HeroSkillsReference[i];
            
            //Enable the game object
            heroPreviewSkill.Transform.gameObject.SetActive(true);
            
            //skill attributes and information
            var skillDescription = skillLogic.SkillInformation.SkillDescription;
            var skillPreviewSprite = skillLogic.SkillInformation.SkillSprite;
            var currentSkillCooldown = skillLogic.SkillAttributes.SkillCooldown;
            var baseSkillSpeed = skillLogic.SkillAttributes.BaseSkillSpeed;
            var skillName = skillLogic.SkillInformation.SkillName;
            var skillType = skillLogic.SkillAttributes.SkillType;
            
            SetPreviewHeroComponents.UpdateHeroPreviewSkillFrame(heroPreviewSkill,heroElement);
            SetPreviewHeroComponents.UpdateSkillPreviewElementText(heroPreviewSkill,heroElement);
            SetPreviewHeroComponents.UpdateSkillPreviewDescriptionText(heroPreviewSkill,skillDescription);
            SetPreviewHeroComponents.UpdateSkillPreviewGraphic(heroPreviewSkill, skillPreviewSprite);
            SetPreviewHeroComponents.UpdateSkillPreviewCooldownText(heroPreviewSkill,skillType,currentSkillCooldown);
            
            SetPreviewHeroComponents.UpdateSkillPreviewSpeedText(heroPreviewSkill, baseSkillSpeed);
            SetPreviewHeroComponents.UpdateSkillPreviewNameText(heroPreviewSkill, skillName);
            
         }
      }
      
      

      
      
      



      #endregion
   }
}
