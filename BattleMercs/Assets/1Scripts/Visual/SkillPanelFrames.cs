using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillPanelFrames : MonoBehaviour, ISkillPanelFrames
   {
      #region VARIABLES
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object skillPanelVisual = null;
      
      [SerializeField] private List<Sprite> frames = new List<Sprite>();

              

      #endregion
        
      #region PROPERTIES
      private ISkillPanelVisual SkillPanelVisual => skillPanelVisual as ISkillPanelVisual;
      /// <summary>
      /// The order set in the inspector should be: Grey-Red-Green-Blue
      /// </summary>
      private List<Sprite> Frames => frames;
      
      #endregion
        
      #region METHODS
      
      public void SetDefaultGreyFrame()
      {
         SkillPanelVisual.SkillPanelImage.sprite = Frames[0];
      }

      public void SetDefenderRedFrame()
      {
         SkillPanelVisual.SkillPanelImage.sprite = Frames[1];
      }
   
      public void SetFighterGreenFrame()
      {
         SkillPanelVisual.SkillPanelImage.sprite = Frames[2];
      }
   
      public void SetCasterBlueFrame()
      {
         SkillPanelVisual.SkillPanelImage.sprite = Frames[3];
      }

      

      #endregion
   }
}
