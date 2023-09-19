using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroFramesVisual : MonoBehaviour, IHeroFramesVisual
   {
      #region VARIABLES
      
      [SerializeField] private Image frameInUse = null;
      
      [SerializeField] private List<Sprite> frameSelection = new List<Sprite>();
        

      #endregion
        
      #region PROPERTIES
      
      private Image FrameInUse => frameInUse;

      private List<Sprite> FrameSelection => frameSelection;

      #endregion
        
      #region METHODS
      
      public void SetColorGreyDefaultFrame( )
      {
         //Element 0 is Grey
         FrameInUse.sprite = FrameSelection[0];
      }
      
      public void SetColorRedFrame()
      {
         //Element 1 is Red
         FrameInUse.sprite = FrameSelection[1];
      }
   
      public void SetColorGreenFrame( )
      {
         //Element 2 is Green
         FrameInUse.sprite = FrameSelection[2];
      }
   
      public void SetColorBlueFrame( )
      {
         //Element 3 is Blue
         FrameInUse.sprite = FrameSelection[3];
      }
   
      
        

      #endregion
   }
}
