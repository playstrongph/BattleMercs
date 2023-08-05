using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class UsedSkillMultiTarget : MonoBehaviour, IUsedSkillMultiTarget
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillSingleTargetVisual))] private List<Object> usedSkillsList = new List<Object>();


      #endregion

      #region PROPERTIES

      public List<IUsedSkillSingleTargetVisual> UsedSkillsList
      {
         get
         {
            var newList = new List<IUsedSkillSingleTargetVisual>();
            foreach (var usedSkill in usedSkillsList)
            {
               newList.Add(usedSkill as IUsedSkillSingleTargetVisual);
            }
            return newList;
         }
      }


      #endregion

      #region METHODS



      #endregion
   }
}
