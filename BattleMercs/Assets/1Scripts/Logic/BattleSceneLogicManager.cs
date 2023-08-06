using System;
using System.Collections;
using _1Scripts.Visual;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class BattleSceneLogicManager : MonoBehaviour, IBattleSceneLogicManager
   {
      #region VARIABLES
   
      [Header("Prefabs")]
      [SerializeField] private GameObject prefabBattleSceneManagerVisual = null;
      
      [Header("Inspector References")]
      [SerializeField] private GameObject battleSceneManagerVisual = null;

      [Header("Components")]
      [SerializeField]
      [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeBattleSceneManagerVisual))] private Object initializeBattleSceneManagerVisual = null;
      

      #endregion

      #region PROPERTIES

      public GameObject PrefabBattleSceneManagerVisual => prefabBattleSceneManagerVisual;

      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual.GetComponent<IBattleSceneManagerVisual>();

      public GameObject SetBattleSceneManagerVisual
      {
         set => battleSceneManagerVisual = value;
      }
      
      //Components
      public IInitializeBattleSceneManagerVisual InitializeBattleSceneManagerVisual => initializeBattleSceneManagerVisual as IInitializeBattleSceneManagerVisual;

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
