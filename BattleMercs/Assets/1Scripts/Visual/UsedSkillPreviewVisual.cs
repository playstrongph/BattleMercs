using UnityEngine;

namespace _1Scripts.Visual
{
   public class UsedSkillPreviewVisual : MonoBehaviour, IUsedSkillPreviewVisual
   {
      #region VARIABLES

      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillSingleTargetVisual))] private Object usedSkillSingleTargetVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillMultiTarget))] private Object usedSkillMultiTarget = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillUsedVisual))] private Object skillUsedVisual = null;

      #endregion

      #region PROPERTIES
      
      //Inspector References
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;
      
      //Components
      public IUsedSkillSingleTargetVisual UsedSkillSingleTargetVisual => usedSkillSingleTargetVisual as IUsedSkillSingleTargetVisual;
      public IUsedSkillMultiTarget UsedSkillMultiTarget => usedSkillMultiTarget as IUsedSkillMultiTarget;
      public ISkillUsedVisual SkillUsedVisual => skillUsedVisual as ISkillUsedVisual;


      #endregion

      #region METHODS



      #endregion
   }
}
