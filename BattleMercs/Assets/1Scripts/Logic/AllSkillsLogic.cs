using System;
using System.Collections.Generic;
using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _1Scripts.Logic
{
   public class AllSkillsLogic : MonoBehaviour, IAllSkillsLogic
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      #pragma warning disable 0649
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;

      [SerializeField] private List<SkillLogic> allSkills = new List<SkillLogic>();

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
               newList.Add(skill);
            }
            return newList;
         }
      }

      #endregion

      #region Structs
      
      [Serializable]
      public struct SkillLogic : ISkillLogic
      {
         
         //Variables
         
         #pragma warning disable 0649
         
         [SerializeField] private string skillNameLabel;
         [SerializeField] private SkillInformationStruct skillInformation;
         [SerializeField] private SkillAttributesStruct skillAttributes;
         
          #pragma warning restore 0649
         
         //Properties
         public string SkillNameLabel { get => skillNameLabel; set => skillNameLabel = value; }
         public ISkillInformation SkillInformation => skillInformation as ISkillInformation;
         public ISkillAttributes SkillAttributes => skillAttributes as ISkillAttributes;
      }

      [Serializable]
      public struct  SkillInformationStruct : ISkillInformation
      {
         //Variables
         #pragma warning disable 0649
         [SerializeField] private string skillName;
         [TextArea(5, 5)] [SerializeField] private string skillDescription;
         [SerializeField] private Sprite skillSprite;
         
         [Header("Runtime References")]
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object casterHero;
         
         #pragma warning restore 0649
         //Properties

         public string SkillName { get => skillName; set => skillName = value; }
         public string SkillDescription { get => skillDescription; set => skillDescription = value; }
         public Sprite SkillSprite { get => skillSprite; set => skillSprite = value; }
         
         public IHeroLogic CasterHero
         {
            get => casterHero as IHeroLogic;
            set => casterHero = value as Object;
         }
         
        
      }
      
      [Serializable]
      public struct  SkillAttributesStruct: ISkillAttributes
      {
         //Variables
         #pragma warning disable 0649
         [SerializeField] private int skillCooldown;
         [SerializeField] private int skillSpeed;
         [SerializeField] private int skillFightingSpirit;
         [SerializeField] private int baseSkillCooldown;
         [SerializeField] private int baseSkillSpeed;
         
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private Object skillElement;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTypeAsset))] private Object skillType;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillReadinessAsset))] private Object skillReadiness;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillEnableStatusAsset))] private Object skillEnableStatus;
         [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetAsset))] private Object skillTargetAsset;

         #pragma warning restore 0649
         
         //Properties
         public int SkillCooldown { get => skillCooldown; set => skillCooldown = value; }
         public int SkillSpeed { get => skillSpeed; set => skillSpeed = value; }
         public int SkillFightingSpirit { get => skillFightingSpirit; set => skillFightingSpirit = value; }
         public int BaseSkillCooldown { get => baseSkillCooldown; set => baseSkillCooldown = value; }
         public int BaseSkillSpeed { get => baseSkillSpeed; set => baseSkillSpeed = value; }

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
         
         public ISkillTargetAsset SkillTargetAsset
         {
            get => skillTargetAsset as ISkillTargetAsset;
            set => skillTargetAsset = value as Object;
         }



      }
      

      #endregion
        
      #region METHODS
      
       
        

      #endregion
   }
}
