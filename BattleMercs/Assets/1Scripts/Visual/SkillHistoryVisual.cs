using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class SkillHistoryVisual : MonoBehaviour, ISkillHistoryVisual
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneVisualManager))] private Object battleSceneManagerVisual = null;

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillHistoryVisual))] private List<Object> usedSkillHistoryVisualList = null;
      
      

      #endregion

      #region PROPERTIES
   
      public IBattleSceneVisualManager BattleSceneVisualManager => battleSceneManagerVisual as IBattleSceneVisualManager;

      public List<IUsedSkillHistoryVisual> UsedSkillHistoryVisualList
      {
         get
         {
            var newList = new List<IUsedSkillHistoryVisual>();
            foreach (var usedSkillHistoryVisual in usedSkillHistoryVisualList)
            {
               newList.Add(usedSkillHistoryVisual as IUsedSkillHistoryVisual);
            }
            return newList;
         }
      }


      #endregion

      #region METHODS



      #endregion
   }
}
