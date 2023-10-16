using UnityEngine;

namespace _1Scripts.Logic
{
   public class SkillLogic : MonoBehaviour, ISkillLogic
   {
      #region VARIABLES
      
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillInformation))]private Object skillInformation;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillAttributes))]private Object skillAttributes;
         
#pragma warning restore 0649

      #endregion
        
      #region PROPERTIES

      public ISkillInformation SkillInformation => skillInformation as ISkillInformation;
      public ISkillAttributes SkillAttributes => skillAttributes as ISkillAttributes;  

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
