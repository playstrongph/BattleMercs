using _1Scripts.Logic.SOLogicScripts;
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
      
      [Header("SO Assets")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneSettingsAsset))] private Object battleSettings;

      [Header("Runtime References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))]private Object battleSceneManagerVisual;
      
      [Header("Children Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllPlayersLogic))] private Object playersLogic;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllHeroesLogic))] private Object allHeroesLogic;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllSkillsLogic))] private Object allSkillsLogic;
      
      [Header("Attached Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleStart))] private Object battleStart;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeBattleSceneManagerVisual))] private Object initializeBattleSceneManagerVisual;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeAllPlayers))] private Object initializeAllPlayers;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeAllHeroes))] private Object initializeAllHeroes;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeAllSkills))] private Object initializeAllSkills;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUniqueIDGenerator))] private Object uniqueIDGenerator;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISetPlayerVisualAndLogicReferences))] private Object setPlayerVisualAndLogicReferences;
      
      
      

#pragma warning restore 0649 // Restore warnings
      #endregion

      #region PROPERTIES

      public GameObject PrefabBattleSceneManagerVisual => prefabBattleSceneManagerVisual;
      
      public IBattleSceneSettingsAsset BattleSettings
      {
         get => battleSettings as IBattleSceneSettingsAsset;
         set => battleSettings = value as Object;
      }
      

      public IBattleSceneManagerVisual BattleSceneManagerVisual
      {
         get => battleSceneManagerVisual as IBattleSceneManagerVisual;
         set => battleSceneManagerVisual = value as Object;
      }
      

      //Components
      public IAllPlayersLogic AllPlayersLogic => playersLogic as IAllPlayersLogic;
      public IAllHeroesLogic AllHeroesLogic => allHeroesLogic as IAllHeroesLogic;
      public IAllSkillsLogic AllSkillsLogic => allSkillsLogic as IAllSkillsLogic;
      
      //Attached Components
      private IBattleStart BattleStart => battleStart as IBattleStart;
      public IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual => initializeBattleSceneManagerVisual as IInitializeBattleSceneManagerVisual;
      public IInitializeAllPlayers InitializeAllPlayers => initializeAllPlayers as IInitializeAllPlayers;
      public IInitializeAllHeroes InitializeAllHeroes => initializeAllHeroes as IInitializeAllHeroes;
      
      public IInitializeAllSkills InitializeAllSkills => initializeAllSkills as IInitializeAllSkills;
      
      public IUniqueIDGenerator UniqueIDGenerator => uniqueIDGenerator as IUniqueIDGenerator;
      public ISetPlayerVisualAndLogicReferences SetPlayerVisualAndLogicReferences => setPlayerVisualAndLogicReferences as ISetPlayerVisualAndLogicReferences;

      public Transform Transform => this.transform;

      #endregion

      #region METHODS
      private void Start()
      {
         //TODO: Load in BattleStart
         //InitializeBattleSceneManagerVisual.StartActions();
         BattleStart.StartAction();
      }

      



      #endregion
   }
}
