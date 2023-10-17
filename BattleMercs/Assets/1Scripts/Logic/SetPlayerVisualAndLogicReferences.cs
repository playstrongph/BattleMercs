using UnityEngine;

namespace _1Scripts.Logic
{
   public class SetPlayerVisualAndLogicReferences : MonoBehaviour
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;


#pragma warning restore 0649
      #endregion

      #region PROPERTIES
      
      private IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;


      #endregion

      #region METHODS

      public void SetReferences()
      {
          
      }



      #endregion
   }
}
