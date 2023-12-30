using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "FireSkillElement", menuName = "Assets/SkillElement/FireSkillElement")]
   public class FireSkillElementAsset : SkillElementAsset
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
         skillPreview.SkillPreviewFrames.SetColorRedElement();
      }
      
      public override void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         skillPreviewVisual.ElementText.text = "Fire";
      }


      #endregion
   }
}
