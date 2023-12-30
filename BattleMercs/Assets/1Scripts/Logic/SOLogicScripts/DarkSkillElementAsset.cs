using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "DarkSkillElement", menuName = "Assets/SkillElement/DarkSkillElement")]
   public class DarkSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void SetSkillElement()
      {
         
      }
      
      public override void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         skillPreviewVisual.ElementText.text = "Dark";
      }
      
      public override void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview)
      {
         skillPreview.SkillPreviewFrames.SetColorDarkElement();
      }


      #endregion
   }
}
