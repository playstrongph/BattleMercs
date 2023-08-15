using _1Scripts.Visual;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class BattleSceneLogicManager : MonoBehaviour, IBattleSceneLogicManager
   {
      #region VARIABLES
   
      [Header("Prefabs")]
      #pragma warning disable 0649 // Disable "Field is never assigned to..." warning
      [SerializeField] private GameObject prefabBattleSceneManagerVisual;
      #pragma warning restore 0649 // Restore warnings
      
      [Header("Runtime References")]
      [SerializeField] private Object battleSceneManagerVisual;

      [Header("Components")]
      #pragma warning disable 0649 // Disable "Field is never assigned to..." warning
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeBattleSceneManagerVisual))] private Object initializeBattleSceneManagerVisual;
      #pragma warning restore 0649 // Restore warnings
      #endregion

      #region PROPERTIES

      public GameObject PrefabBattleSceneManagerVisual => prefabBattleSceneManagerVisual;

      public IBattleSceneManagerVisual BattleSceneManagerVisual
      {
         get => battleSceneManagerVisual as IBattleSceneManagerVisual;
         set => battleSceneManagerVisual = value as Object;
      }

      //Components
      private IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual => initializeBattleSceneManagerVisual as IInitializeBattleSceneManagerVisual;

      #endregion

      #region METHODS
      private void Start()
      {
         //TODO: In the future, Network instantiate
         InitializeBattleSceneManagerVisual.StartActions();
      }

      



      #endregion
   }
}
