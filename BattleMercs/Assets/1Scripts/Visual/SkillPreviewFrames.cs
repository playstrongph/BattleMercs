using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillPreviewFrames : MonoBehaviour, ISkillPreviewFrames
   {
      #region VARIABLES
      
      [SerializeField] private Image skillPreviewFrame = null;  
      
      [SerializeField] private List<Sprite> frames = new List<Sprite>();
     

      #endregion
        
      #region PROPERTIES
      
      private List<Sprite> Frames => frames;

      private Image SkillPreviewFrame => skillPreviewFrame;
        

      #endregion
        
      #region METHODS
      
      public void SetColorGreyDefault()
      {
         //Element 0 is Grey
         SkillPreviewFrame.sprite = Frames[0];
      }
      
      public void SetColorRedElement()
      {
         //Element 1 is Red
         SkillPreviewFrame.sprite = Frames[1];
      }
   
      public void SetColorGreenElement()
      {
         //Element 2 is Green
         SkillPreviewFrame.sprite = Frames[2];
      }
   
      public void SetColorBlueElement()
      {
         //Element 3 is Blue
         SkillPreviewFrame.sprite = Frames[3];
      }
      
      public void SetColorLightElement()
      {
         //Element 4 is Light
         SkillPreviewFrame.sprite = Frames[4];
      }
      
      public void SetColorDarkElement()
      {
         //Element 5 is Blue
         SkillPreviewFrame.sprite = Frames[5];
      }
   
      
        

      #endregion
   }
}
