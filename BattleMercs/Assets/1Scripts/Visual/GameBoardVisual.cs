using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class GameBoardVisual : MonoBehaviour, IGameBoardVisual
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;

      [Header("Components")] 
      [SerializeField] private Canvas canvas = null;

      [SerializeField] private Image image = null;


      #endregion

      #region PROPERTIES
      
      
      public IBattleSceneVisualManager BattleSceneVisualManager
      {
         get => battleSceneManagerVisual as IBattleSceneVisualManager;
         private set => battleSceneManagerVisual = value as Object;
      }

      public Canvas Canvas
      {
         get => canvas as Canvas;
         private set => canvas = value;
      }
      
      public Image Image
      {
         get => image as Image;
         private set => image = value;
      }
      
      


      #endregion

      #region METHODS



      #endregion
   }
}
