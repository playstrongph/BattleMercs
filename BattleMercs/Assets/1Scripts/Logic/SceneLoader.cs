using System;
using _1Scripts.Logic.SOLogicScripts;
using _1Scripts.Visual;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class SceneLoader : MonoBehaviour, ISceneLoader
   {
      #region VARIABLES
#pragma warning disable 0649

       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISceneManagersAsset))] private Object sceneManagersAsset;

#pragma warning restore 0649

       #endregion

       #region PROPERTIES

       private ISceneManagersAsset SceneManagersAsset => sceneManagersAsset as ISceneManagersAsset;

       #endregion

       #region METHODS

       private void Start()
       {
           InitializeSceneManagers();
       }

       private void InitializeSceneManagers()
       {
           var logicManagerObject = Instantiate(SceneManagersAsset.BattleSceneLogicManager,transform);
           var visualManagerObject = Instantiate(SceneManagersAsset.BattleSceneVisualManager,transform);
           
           
           var logicManager = logicManagerObject.GetComponent<IBattleSceneLogicManager>();
           var visualManager = visualManagerObject.GetComponent<IBattleSceneVisualManager>();

           //Set References
           logicManager.BattleSceneVisualManager = visualManager;
           visualManager.BattleSceneLogicManager = logicManager;
           
           //TEST
           logicManager.BattleStart.StartAction();
       }

       #endregion
   }
}
