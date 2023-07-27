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
      
      public void SetColorRedDefenderFrame()
      {
         //Element 0 is Red
         FrameInUse.sprite = FrameSelection[0];
      }
   
      public void SetColorGreenFighterFrame( )
      {
         //Element 1 is Green
         FrameInUse.sprite = FrameSelection[1];
      }
   
      public void SetColorBlueCasterFrame( )
      {
         //Element 2 is Blue
         FrameInUse.sprite = FrameSelection[2];
      }
   
      public void SetColorGreyDefaultFrame( )
      {
         //Element 3 is Grey
         FrameInUse.sprite = FrameSelection[3];
      }
        

      #endregion
   }
}
