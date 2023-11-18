using _1Scripts.Visual;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class InitializeBattleSceneManagerVisual : MonoBehaviour, IInitializeBattleSceneManagerVisual
   {
      #region VARIABLES

      [Header("Components")]
      [SerializeField]
      [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager = null;


      #endregion

      #region PROPERTIES

      private IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;

      #endregion

      #region METHODS
      
      /// <summary>
      /// Creates the visual manager and sets the respective references
      /// //TODO: In the future, Network instantiate
      /// </summary>
      public void StartActions()
      {
         var prefab = BattleSceneLogicManager.PrefabBattleSceneManagerVisual;

         //Set New Instance Reference
         BattleSceneLogicManager.BattleSceneVisualManager = Instantiate(prefab).GetComponent<IBattleSceneVisualManager>();
         
         //Set LogicManager reference of VisualManager
         BattleSceneLogicManager.BattleSceneVisualManager.BattleSceneLogicManager = BattleSceneLogicManager;

      }

      #endregion
   }
}
