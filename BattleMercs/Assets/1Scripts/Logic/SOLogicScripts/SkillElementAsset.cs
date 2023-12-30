using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   public class SkillElementAsset : ScriptableObject, ISkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void SetSkillElement()
      {
         
      }

      public virtual void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         
      }

      public virtual void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview)
      {
         skillPreview.SkillPreviewFrames.SetColorDarkElement();

      }


      #endregion
   }
}
