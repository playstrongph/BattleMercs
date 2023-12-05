﻿using System;
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
         UpdateAllHeroPreviewHeroVisualComponents(heroVisual);
         
         Canvas.enabled = true;
      }
      
      /// <summary>
      /// Updates all of the components and sets the heroLogic reference
      /// </summary>
      /// <param name="heroVisual"></param>
      private void UpdateAllHeroPreviewHeroVisualComponents(IHeroVisual heroVisual)
      {
         //Set References
         HeroVisualReference = heroVisual;

         //Change the HeroPreviewVisual Hero Object Name
         SetPreviewHeroComponents.UpdateHeroPreviewGameObjectName();
         
         //Update the components
         SetPreviewHeroComponents.UpdateHeroPreviewHeroGraphic();
         SetPreviewHeroComponents.UpdateHeroPreviewFrame();
         SetPreviewHeroComponents.UpdateHeroPreviewAttackText();
         SetPreviewHeroComponents.UpdateHeroPreviewHealthText();
         SetPreviewHeroComponents.UpdateHeroPreviewArmorText();
         SetPreviewHeroComponents.UpdateHeroPreviewNameText();
         SetPreviewHeroComponents.UpdateHeroPreviewClassText();
      }

      
      
      public void HideHeroPreviewVisual()
      {
         Canvas.enabled = false;
      }



      #endregion
   }
}
