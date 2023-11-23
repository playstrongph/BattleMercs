using System.Collections.Generic;
using _1Scripts.Logic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class HeroPreviewVisual : MonoBehaviour, IHeroPreviewVisual
   {
      #region VARIABLES
      
      [Header("RUNTIME REFERENCES")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object heroLogicReference = null;
    
      
      [Header("COMPONENTS")] 
      [SerializeField] private Canvas canvas = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewHero))] private Object heroPreviewHero = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewSkill))] private List<Object> heroPreviewSkillList = new List<Object>();

      [Header("INSPECTOR REFERENCES")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetPreviewHeroComponents))] private Object setPreviewHeroComponents = null;
    
      

      
      
      #endregion

      #region PROPERTIES
      
      //Runtime References
      public IHeroLogic HeroLogicReference
      {
         get => heroLogicReference as IHeroLogic;
         set => heroLogicReference = value as Object;
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
      
      /// <summary>
      /// Updates all of the components and sets the heroLogic reference
      /// </summary>
      /// <param name="heroLogic"></param>
      public void UpdateAllHeroPreviewHeroVisualComponents(IHeroLogic heroLogic)
      {
         //Set References
         HeroLogicReference = heroLogic;
         //TODO: HeroLogic Hero Preview Visual Reference
         
         //Change the HeroPreviewVisual Hero Object Name
         SetPreviewHeroComponents.UpdateHeroPreviewGameObjectName();
         
         //Update the components
         SetPreviewHeroComponents.UpdateHeroPreviewFrame();
         SetPreviewHeroComponents.UpdateHeroPreviewAttackText();
         SetPreviewHeroComponents.UpdateHeroPreviewHealthText();
         SetPreviewHeroComponents.UpdateHeroPreviewArmorText();
         SetPreviewHeroComponents.UpdateHeroPreviewNameText();
         SetPreviewHeroComponents.UpdateHeroPreviewClassText();
      }

      #endregion
   }
}
