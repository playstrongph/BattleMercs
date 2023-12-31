using System;
using UnityEngine;
using Object = UnityEngine.Object;


namespace _1Scripts.Visual
{
   
   public class SkillVisualInputActions : MonoBehaviour, ISkillVisualInputActions
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

        

      #endregion
        
      #region PROPERTIES
      
      public ISkillVisual SkillVisual => skillVisual as ISkillVisual;

        

      #endregion
        
      #region METHODS

      private void OnMouseDown()
      {
         //Targeting 
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillTargetingVisual.SelectSkillTargetVisual.SkillTargetingPermissiveChecks(SkillVisual);
         
         //Skill Preview
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillPreviewVisual.ShowSkillPreviewVisual(SkillVisual);
         
      }

      private void OnMouseUp()
      {
         //Targeting 
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillTargetingVisual.ResetPositionToOrigin();
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillTargetingVisual.Draggable.DisableDraggable();
         
         //Skill Preview
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillPreviewVisual.HideSkillPreviewVisual();
      }

      private void OnMouseEnter()
      {
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillPreviewVisual.ShowSkillPreviewVisual(SkillVisual);
      }
      
      private void OnMouseExit()
      {
         SkillVisual.HeroSkillsVisual.BattleSceneVisualManager.SkillPreviewVisual.HideSkillPreviewVisual();
      }
      
      

      #endregion
   }
}
