using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
    [CreateAssetMenu(fileName = "NewSceneManagers", menuName = "Assets/BattleSceneSettings/NewSceneManagers")]
   public class SceneManagersAsset : ScriptableObject, ISceneManagersAsset
   {
      #region VARIABLES
#pragma warning disable 0649
      [SerializeField] private GameObject battleSceneLogicManager;  
      [SerializeField] private GameObject battleSceneVisualManager;
      
#pragma warning restore 0649
       
      #endregion
        
      #region PROPERTIES

      public GameObject BattleSceneLogicManager => battleSceneLogicManager;
      public GameObject BattleSceneVisualManager => battleSceneVisualManager;   

      #endregion
        
      #region METHODS




      #endregion
   }
}
