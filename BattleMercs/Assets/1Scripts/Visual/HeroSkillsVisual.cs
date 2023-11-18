using UnityEngine;

namespace _1Scripts.Visual
{
   public class HeroSkillsVisual : MonoBehaviour, IHeroSkillsVisual
   {
      #region VARIABLES

      [Header("Components")] 
      

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object threeSkillPanelVisual = null;
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object fourSkillPanelVisual = null;
      [SerializeField] private Canvas canvas = null;

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;
      
      

      #endregion

      #region PROPERTIES
      private Canvas Canvas => canvas;
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;

      public ISkillPanelVisual ThreeSkillPanelVisual => threeSkillPanelVisual as ISkillPanelVisual;
      
      public ISkillPanelVisual FourSkillPanelVisual => fourSkillPanelVisual as ISkillPanelVisual;


      #endregion

      #region METHODS

      public void ShowHeroSkillsVisual()
      {
         Canvas.enabled = true;
      }
      
      public void HideHeroSkillsVisual()
      {
         Canvas.enabled = false;
      }
      
      
      


      #endregion
   }
}
