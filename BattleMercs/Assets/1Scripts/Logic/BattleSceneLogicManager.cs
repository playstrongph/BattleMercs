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
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;

      #endregion

      #region PROPERTIES

      private IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;
      

      #endregion

      #region METHODS

      private void Start()
      {
         //TODO: In the future, perform a Network Instantiate for both host and clients
         battleSceneManagerVisual = Instantiate(prefabBattleSceneManagerVisual);
         
         //TEST
         StartCoroutine(TestSetValue(battleSceneManagerVisual as GameObject));
      }

      private IEnumerator TestSetValue(GameObject test)
      {
         test.GetComponent<IBattleSceneManagerVisual>().BattleSceneLogicManager = this;
         yield return null;
      }



      #endregion
   }
}
