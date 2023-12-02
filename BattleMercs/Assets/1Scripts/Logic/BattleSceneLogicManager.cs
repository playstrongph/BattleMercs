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
   
      [Header("SO Assets")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneSettingsAsset))] private Object battleSettings;

      [Header("Runtime References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))]private Object battleSceneManagerVisual;
      
      [Header("Inspector Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAllPlayersLogic))] private Object playersLogic;

      [Header("Script Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleStart))] private Object battleStart;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeAllPlayerLogics))] private Object initializeAllPlayers;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISelectEnemyPlayer))] private Object selectEnemyPlayer;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUniqueIDGenerator))] private Object uniqueIDGenerator;

#pragma warning restore 0649 // Restore warnings
      #endregion

      #region PROPERTIES

      public IBattleSceneSettingsAsset BattleSettings
      {
         get => battleSettings as IBattleSceneSettingsAsset;
         set => battleSettings = value as Object;
      }
      

      public IBattleSceneVisualManager BattleSceneVisualManager
      {
         get => battleSceneManagerVisual as IBattleSceneVisualManager;
         set => battleSceneManagerVisual = value as Object;
      }
      

      //Components
      public IAllPlayersLogic AllPlayersLogic => playersLogic as IAllPlayersLogic;
      //Attached Components
      public IBattleStart BattleStart => battleStart as IBattleStart;
      public IInitializeAllPlayerLogics InitializeAllPlayerLogics => initializeAllPlayers as IInitializeAllPlayerLogics;
      public ISelectEnemyPlayer SelectEnemyPlayer => selectEnemyPlayer as ISelectEnemyPlayer;
      public IUniqueIDGenerator UniqueIDGenerator => uniqueIDGenerator as IUniqueIDGenerator;
      public Transform Transform => this.transform;

      #endregion

      #region METHODS
     

      



      #endregion
   }
}
