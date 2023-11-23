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


      #endregion

      #region METHODS



      #endregion
   }
}
