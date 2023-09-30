using UnityEngine;
using UnityEngine.Serialization;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "NewSkillAsset", menuName = "Assets/SkillAssets/NewSkillAsset")]
   public class SkillAsset : ScriptableObject, ISkillAsset
   {
      #region VARIABLES
      
      #pragma warning disable 0649
      
      [Header("Skill Information")]
      [SerializeField] private string skillName;
      
      [TextArea(15,20)]
      [SerializeField] private string skillDescription;
      [SerializeField] private Sprite skillSprite;

      [Header("Skill Attributes")]
      
      //Set to "0" to make it initially available
      [SerializeField] private int skillCooldown;
      [SerializeField] private int skillSpeed;
      [SerializeField] private int skillFightingSpirit;
      [SerializeField] private int skillFocusPoints;
      
      //Base Cooldown and other costs
      [SerializeField] private int fightingSpiritCost;
      [SerializeField] private int focusPointsCost;
      [SerializeField] private int baseSkillCooldown;
      [SerializeField] private int baseSkillSpeed;
      

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private Object skillElement;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTypeAsset))] private Object skillType;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillReadinessAsset))] private Object skillReadiness;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillEnableStatusAsset))] private Object skillEnableStatus;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetAsset))] private Object skillTarget;

      #pragma warning restore 0649

      #endregion

      #region PROPERTIES

      public string SkillName => skillName;
      public string SkillDescription => skillDescription;
      public Sprite SkillSprite => skillSprite;

      public int SkillCooldown => skillCooldown;
      public int SkillSpeed => skillSpeed;
      public int SkillFightingSpirit => skillFightingSpirit;
      
      public int FightingSpiritCost => fightingSpiritCost;
      public int BaseSkillCooldown => baseSkillCooldown;
      public int SkillFocusPoints => skillFocusPoints;
      public int FocusPointsCost => focusPointsCost;
      public int BaseSkillSpeed => baseSkillSpeed;
      
      public ISkillElementAsset SkillElement => skillElement as ISkillElementAsset;
      public ISkillTypeAsset SkillType => skillType as ISkillTypeAsset;
      public ISkillReadinessAsset SkillReadiness => skillReadiness as ISkillReadinessAsset;
      public ISkillEnableStatusAsset SkillEnableStatus => skillEnableStatus as ISkillEnableStatusAsset;
      public ISkillTargetAsset SkillTarget => skillTarget as ISkillTargetAsset;

      #endregion

      #region METHODS



      #endregion
   }
}
