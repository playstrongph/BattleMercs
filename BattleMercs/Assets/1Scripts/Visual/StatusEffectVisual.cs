using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class StatusEffectVisual : MonoBehaviour, IStatusEffectVisual
   {
      #region VARIABLES
      
      [Header("Components")] 
      [SerializeField] private Canvas canvas = null;
      [SerializeField] private Image frame = null;
      [SerializeField] private Image icon = null;
      [SerializeField] private TextMeshProUGUI counters = null;
        

      #endregion
        
      #region PROPERTIES
      
      private Canvas Canvas => canvas;
      private Image Frame => frame;
      private Image Icon => icon;
      private TextMeshProUGUI Counters => counters;
        

      #endregion
        
      #region METHODS
      
      public void SetFrame(Sprite newFrame)
      {
         Frame.sprite = newFrame;
      }

      public void SetIcon(Sprite newIcon)
      {
         Icon.sprite = newIcon;
      }
   
      public void SetCounters(int newCounters)
      {
         Counters.text = newCounters>0 ? newCounters.ToString() : "";
      }

      public void ShowStatusEffectVisual()
      {
         Canvas.enabled = true;
      }

      public void HideStatusEffectVisual()
      {
         Canvas.enabled = false;
      }


      #endregion
   }
}
