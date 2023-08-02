using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class HeroPreviewVisual : MonoBehaviour, IHeroPreviewVisual
   {
      #region VARIABLES

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;

      [Header("Components")] 
      [SerializeField] private Canvas canvas = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewHero))] private Object heroPreviewHero = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewSkill))] private List<Object> heroPreviewSkillList = new List<Object>();
      
      #endregion

      #region PROPERTIES
      
      //Inspector References
      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;
      
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
