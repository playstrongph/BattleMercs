using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "PlayerIDNUmber", menuName = "Assets/PlayerID/PlayerIDNUmber")]
   public class PlayerNumberAsset : ScriptableObject, IPlayerNumberAsset
   {
      #region VARIABLES

      [SerializeField] private string uniquePlayerID = "";


      #endregion

      #region PROPERTIES

      public string UniquePlayerID => uniquePlayerID;

      #endregion

      #region METHODS



      #endregion
   }
}
