using UnityEngine;

namespace _1Scripts.Visual
{
   public class BattleSceneManagerVisual : MonoBehaviour, IBattleSceneManagerVisual
   {
      #region VARIABLES
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoardVisual))] private Object gameBoardVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object mainPlayerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerVisual))] private Object enemyPlayerVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsVisual))] private Object heroSkillsVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillHistoryVisual))] private Object skillHistoryVisual = null;
      
      #endregion

      #region PROPERTIES
      
      public IPlayerVisual MainPlayerVisual => mainPlayerVisual as IPlayerVisual;
      public IPlayerVisual EnemyPlayerVisual => enemyPlayerVisual as IPlayerVisual;
      public IGameBoardVisual GameBoardVisual
      {
         get => gameBoardVisual as IGameBoardVisual;
         private set => gameBoardVisual = value as Object;
      }
      public IHeroSkillsVisual HeroSkillsVisual => heroSkillsVisual as IHeroSkillsVisual;
      public ISkillHistoryVisual SkillHistoryVisual => skillHistoryVisual as ISkillHistoryVisual;

      #endregion

      #region METHODS



      #endregion
   }
}
