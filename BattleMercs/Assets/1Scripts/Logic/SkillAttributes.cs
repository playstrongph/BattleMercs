using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using UnityEngine.Serialization;

namespace _1Scripts.Logic
{
   public class SkillAttributes : MonoBehaviour, ISkillAttributes
   {
      #region VARIABLES
      
#pragma warning disable 0649
         
      [Header("Basic Skill Attribute Values")]
      [SerializeField] private int skillCooldown;
      [SerializeField] private int skillSpeed;
      [SerializeField] private int baseSkillCooldown;
      [SerializeField] private int baseSkillSpeed;
         
         
      [Header("Other Skill Attribute Values")]
      [SerializeField] private int skillFightingSpirit;
      [SerializeField] private int skillFocusPoints;
      [SerializeField] private int skillStackingCounters;
         
      [SerializeField] private int fightingSpiritCost;
      [SerializeField] private int focusPointsCost;
      [SerializeField] private int stackingCountersLimit;
        
      [Header("Skill Attribute Assets")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private Object skillElement;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTypeAsset))] private Object skillType;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillReadinessAsset))] private Object skillReadiness;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillEnableStatusAsset))] private Object skillEnableStatus;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetAsset))] private Object skillTarget;

#pragma warning restore 0649
        

      #endregion
        
      #region PROPERTIES
      
      //Base Skill Attribute Values
         public int SkillCooldown { get => skillCooldown; set => skillCooldown = value; }
         public int SkillSpeed { get => skillSpeed; set => skillSpeed = value; }
         public int BaseSkillCooldown { get => baseSkillCooldown; set => baseSkillCooldown = value; }
         public int BaseSkillSpeed { get => baseSkillSpeed; set => baseSkillSpeed = value; }
         
         //Other Skill Attribute Values
         public int SkillFightingSpirit { get => skillFightingSpirit; set => skillFightingSpirit = value; }
         public int SkillFocusPoints { get => skillFocusPoints; set => skillFocusPoints = value; }
         public int FightingSpiritCost { get => fightingSpiritCost; set => fightingSpiritCost = value; }
         public int FocusPointsCost { get => focusPointsCost; set => focusPointsCost = value; }
         public int SkillStackingCounters { get => skillStackingCounters; set => skillStackingCounters = value; }
         public int StackingCountersLimit { get => stackingCountersLimit; set => stackingCountersLimit = value; }
         
         //Skill Attribute Assets
         public ISkillElementAsset SkillElementAsset
         {
            get => skillElement as ISkillElementAsset;
            set => skillElement = value as Object;
         }
         
         public ISkillTypeAsset SkillType
         {
            get => skillType as ISkillTypeAsset;
            set => skillType = value as Object;
         }
         
         public ISkillReadinessAsset SkillReadiness
         {
            get => skillReadiness as ISkillReadinessAsset;
            set => skillReadiness = value as Object;
         }
         
         public ISkillEnableStatusAsset SkillEnableStatus
         {
            get => skillEnableStatus as ISkillEnableStatusAsset;
            set => skillEnableStatus = value as Object;
         }
         
         public ISkillTargetAsset SkillTarget
         {
            get => skillTarget as ISkillTargetAsset;
            set => skillTarget = value as Object;
         }
        

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
