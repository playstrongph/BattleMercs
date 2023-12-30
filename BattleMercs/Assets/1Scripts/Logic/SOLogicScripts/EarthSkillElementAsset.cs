using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "EarthSkillElement", menuName = "Assets/SkillElement/EarthSkillElement")]
   public class EarthSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void SetSkillElement()
      {
         
      }
      
      public override void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview)
      {
         skillPreview.SkillPreviewFrames.SetColorGreenElement();
      }
      
      public override void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         skillPreviewVisual.ElementText.text = "Earth";
      }


      #endregion
   }
}
