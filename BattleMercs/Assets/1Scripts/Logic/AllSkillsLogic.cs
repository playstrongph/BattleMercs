using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class AllSkillsLogic : MonoBehaviour, IAllSkillsLogic
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      #pragma warning disable 0649
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;

      [SerializeField] private List<Object> allSkills = new List<Object>();

      #pragma warning restore 0649
      #endregion
        
      #region PROPERTIES

      public IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;
      
      public List<ISkillLogic> AllSkills
      {
         get
         {
            var newList = new List<ISkillLogic>();
            foreach (var skill in allSkills)
            {
               newList.Add(skill as ISkillLogic);
            }
            return newList;
         }
      }

      public Transform Transform => this.transform;

      #endregion


      #region METHODS

      public void AddToAllSkillsList(ISkillLogic newSkill)
      {
         AllSkills.Add(newSkill);
      }


      #endregion
   }
}
