using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "LightSkillElement", menuName = "Assets/SkillElement/LightSkillElement")]
   public class LightSkillElementAsset : SkillElementAsset
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
         skillPreview.SkillPreviewFrames.SetColorLightElement();
      }
      
      public override void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         skillPreviewVisual.ElementText.text = "Light";
      }


      #endregion
   }
}
