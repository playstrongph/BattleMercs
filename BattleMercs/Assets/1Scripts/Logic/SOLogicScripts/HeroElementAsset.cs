﻿using _1Scripts.Visual;
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
      
      
        

      #endregion
   }
}
