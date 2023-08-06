using _1Scripts.Logic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _1Scripts.Visual
{
   public class BattleSceneManagerVisual : MonoBehaviour, IBattleSceneManagerVisual
   {
      #region VARIABLES

      [Header("Inspector References")]
      [SerializeField]
      [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoardVisual))] private Object gameBoardVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object mainPlayerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object enemyPlayerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsVisual))] private Object heroSkillsVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillHistoryVisual))] private Object skillHistoryVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ICombatButtonVisual))] private Object combatButtonVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewVisual))] private Object heroPreviewVisual = null;
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewVisual))] private Object skillPreviewVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillPreviewVisual))] private Object usedSkillPreviewVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingVisual))] private Object skillTargetingVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDisplaySkillTargetingVisual))] private Object displaySkillTargetingVisual = null;

      [SerializeField] private Camera battleSceneCamera = null;
      [SerializeField] private EventSystem visualEventSystem = null;
      
      #endregion

      #region PROPERTIES

      public IBattleSceneLogicManager BattleSceneLogicManager
      {
         get => battleSceneLogicManager as IBattleSceneLogicManager;
         set => battleSceneLogicManager = value as Object;
      }
      public IPlayerVisual MainPlayerVisual => mainPlayerVisual as IPlayerVisual;
      public IPlayerVisual EnemyPlayerVisual => enemyPlayerVisual as IPlayerVisual;
      public IGameBoardVisual GameBoardVisual
      {
         get => gameBoardVisual as IGameBoardVisual;
         private set => gameBoardVisual = value as Object;
      }
      public IHeroSkillsVisual HeroSkillsVisual => heroSkillsVisual as IHeroSkillsVisual;
      public ISkillHistoryVisual SkillHistoryVisual => skillHistoryVisual as ISkillHistoryVisual;
      public ICombatButtonVisual CombatButtonVisual => combatButtonVisual as ICombatButtonVisual;
      public IHeroPreviewVisual HeroPreviewVisual  => heroPreviewVisual as IHeroPreviewVisual;
      public ISkillPreviewVisual SkillPreviewVisual  => skillPreviewVisual as ISkillPreviewVisual;
      public IUsedSkillPreviewVisual UsedSkillPreviewVisual  => usedSkillPreviewVisual as IUsedSkillPreviewVisual;
      public ISkillTargetingVisual SkillTargetingVisual  => skillTargetingVisual as ISkillTargetingVisual;
      public IDisplaySkillTargetingVisual DisplaySkillTargetingVisual  => displaySkillTargetingVisual as IDisplaySkillTargetingVisual;
      public Camera BattleSceneCamera => battleSceneCamera;
      public EventSystem VisualEventSystem => visualEventSystem;

      public Transform ThisTransform => this.transform;


      #endregion

      #region METHODS



      #endregion
   }
}
