using UnityEngine;

namespace _1Scripts.Visual
{
   public class SelectSkillTargetVisual : MonoBehaviour, ISelectSkillTargetVisual
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingVisual))] private Object skillTargetingVisual = null;
        

      #endregion
        
      #region PROPERTIES

      public ISkillTargetingVisual SkillTargetingVisual => skillTargetingVisual as ISkillTargetingVisual;  

      #endregion
        
      #region METHODS

      public void SelectingSkillTarget(ISkillVisual skillVisual)
      {
         SkillTargetingVisual.ThisTransform = skillVisual.ThisTransform;

        SkillTargetingVisual.Draggable.EnableDraggable();
      }


      #endregion
   }
}
