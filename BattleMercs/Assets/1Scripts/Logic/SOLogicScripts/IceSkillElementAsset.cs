using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "IceSkillElement", menuName = "Assets/SkillElement/IceSkillElement")]
   public class IceSkillElementAsset : SkillElementAsset
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
         skillPreview.SkillPreviewFrames.SetColorBlueElement();
      }
      
      public override void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual)
      {
         skillPreviewVisual.ElementText.text = "Ice";
      }


      #endregion
   }
}
