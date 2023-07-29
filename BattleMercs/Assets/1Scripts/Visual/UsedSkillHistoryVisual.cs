using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class UsedSkillHistoryVisual : MonoBehaviour, IUsedSkillHistoryVisual
   {
      #region VARIABLES

      [SerializeField] private Image skillGraphic = null;


      #endregion

      #region PROPERTIES

      private Image SkillGraphic => skillGraphic;


      #endregion

      #region METHODS

      public void SetUsedSkillHistoryVisualGraphic(Sprite sprite)
      {
         SkillGraphic.sprite = sprite;
      }


      #endregion
   }
}
