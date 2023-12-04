using System;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   /// <summary>
   /// Fighter Green
   /// Caster Blue
   /// Defender Red
   /// </summary>
   public class HeroClassAsset : ScriptableObject, IHeroClassAsset
   {
      #region METHODS

      public virtual void SetClassColor(IHeroLogic heroLogic)
      {
         

      }

      public virtual string ClassName => "HeroClass";

      #endregion
   }
}
