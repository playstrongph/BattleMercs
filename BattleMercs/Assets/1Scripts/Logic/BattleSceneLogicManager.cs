using _1Scripts.Visual;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class BattleSceneLogicManager : MonoBehaviour, IBattleSceneLogicManager
   {
      #region VARIABLES
#pragma warning disable 0649 // Disable "Field is never assigned to..." warning
   
      [Header("Prefabs")]
      
      [SerializeField] private GameObject prefabBattleSceneManagerVisual;

      [Header("Runtime References")]
      [SerializeField] private Object battleSceneManagerVisual;
      
      [Header("Children Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayersLogic))] private Object playersLogic;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllHeroesLogic))] private Object allHeroesLogic;
      
      [Header("Attached Components")]
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
      public IPlayersLogic PlayersLogic => playersLogic as IPlayersLogic;
      public IAllHeroesLogic AllHeroesLogic => allHeroesLogic as IAllHeroesLogic;
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
