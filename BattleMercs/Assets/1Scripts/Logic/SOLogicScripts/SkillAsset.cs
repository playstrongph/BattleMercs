using UnityEngine;

namespace _1Scripts.Logic.SOLogicScripts
{
   [CreateAssetMenu(fileName = "NewSkillAsset", menuName = "Assets/SkillAssets/NewSkillAsset")]
   public class SkillAsset : ScriptableObject, ISkillAsset
   {
      #region VARIABLES
      
      #pragma warning disable 0649
      
      [Header("Skill Information")]
      [SerializeField] private string skillName;
      [SerializeField] private string skillDescription;
      [SerializeField] private Sprite skillSprite;

      [Header("Skill Attributes")]
      [SerializeField] private int skillCooldown;
      [SerializeField] private int skillSpeed;
      [SerializeField] private int skillFightingSpirit;
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
      public int BaseSkillCooldown => baseSkillCooldown;
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
