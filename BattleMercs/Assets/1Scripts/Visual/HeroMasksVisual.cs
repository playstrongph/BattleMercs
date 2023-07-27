using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class HeroMasksVisual : MonoBehaviour, IHeroMasksVisual
   {
      #region VARIABLES
      
      [SerializeField] private Image maskImageInUse = null;

      [SerializeField] private List<Sprite> maskSelections = new List<Sprite>();
        

      #endregion
        
      #region PROPERTIES

      private List<Sprite> MaskSelections => maskSelections;
      private Image MaskImageInUse => maskImageInUse;

      #endregion
        
      #region METHODS
      
      public void SetRedMask()
      {
         MaskImageInUse.sprite = MaskSelections[0];
      }
   
      public void SetGreenMask()
      {
         MaskImageInUse.sprite = MaskSelections[1];
      }
   
      public void SetBlueMask()
      {
         MaskImageInUse.sprite = MaskSelections[2];
      }
        

      #endregion
   }
}
