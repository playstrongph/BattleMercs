using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   /// <summary>
   /// Fighter Green
   /// Caster Blue
   /// Defender Red
   /// </summary>
   public class HeroElementAsset : ScriptableObject, IHeroElementAsset
   {
      #region METHODS

      public virtual void SetHeroClassColor(IHeroVisual heroVisual)
      {
         
      }

      public virtual void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill)
      {
         

      }
      
      public virtual void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual)
      {
         

      }
      
      public virtual void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill)
      {
         

      }

      public virtual void UpdateSkillPanelFrameVisual(ISkillPanelVisual skillPanelVisual)
      {
         //0 - default
         //1 - red
         //2 - green
         //3 - blue
         //4 - dark
         //5 - light
      }




      #endregion
   }
}
