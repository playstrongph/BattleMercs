using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillPanelVisual : MonoBehaviour, ISkillPanelVisual
   {
      #region VARIABLES

      [Header("Components")]
      [SerializeField] private Image skillPanelImage = null;
      [SerializeField] private Canvas canvas = null;

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelFrames))] private Object skillPanelFrames = null;
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private List<Object> skillVisualList = new List<Object>();

      #endregion

      #region PROPERTIES

      public Image SkillPanelImage => skillPanelImage;
      private Canvas Canvas => canvas;
      
      public ISkillPanelFrames SkillPanelFrames => skillPanelFrames as ISkillPanelFrames;

      public List<ISkillVisual> SkillVisualList
      {
         get
         {
            var newList = new List<ISkillVisual>();
            foreach (var skillVisual in skillVisualList)
            {
               newList.Add(skillVisual as ISkillVisual);
            }
            return newList;
         }
      }

      public Transform Transform => transform;

      #endregion

      #region METHODS

      public void ShowSkillPanel()
      {
         Canvas.enabled = true;
      }
      
      public void HideSkillPanel()
      {
         Canvas.enabled = true;
      }


      #endregion
   }
}
