using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class CombatButtonVisual : MonoBehaviour, ICombatButtonVisual
   {
      #region VARIABLES
      
      
      
      [Header("Components")]
      [SerializeField] private Image buttonImage = null;
      [SerializeField] private Canvas canvas = null;
      [SerializeField] private List<Sprite> buttonSprites = new List<Sprite>();
      [SerializeField] private TextMeshProUGUI buttonText = null;
      [SerializeField] private Button button = null;

      [Header("Inspector References")]
      [SerializeField]
      [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;

      #endregion
        
      #region PROPERTIES

      //Components
      private Image ButtonImage => buttonImage;
   
      /// <summary>
      /// Sequence: Grey - Green - Yellow
      /// </summary>
      private List<Sprite> ButtonSprites => buttonSprites;

      private TextMeshProUGUI ButtonText => buttonText;

      private Button Button => button;
      
      public Canvas Canvas => canvas;
      
      
      //Inspector References
      
      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;

      #endregion
        
      #region METHODS

      private void ButtonAction()
      {
         //TEST
         Debug.Log("Combat Button Action");
         //Good practice to disable after first click
         //Button.interactable = false;
      
         //Test method only
         var x = Random.Range(0, 3);
         ButtonImage.sprite = ButtonSprites[x];
      }

      

      public void SetButtonText(string text)
      {
         ButtonText.text = text;
      }

      public void SetGreyButton()
      {
         ButtonImage.sprite = ButtonSprites[0];
      }
   
      public void SetGreenButton()
      {
         ButtonImage.sprite = ButtonSprites[1];
      }
   
      public void SetYellowButton()
      {
         ButtonImage.sprite = ButtonSprites[2];
      }

      #endregion
   }
}
