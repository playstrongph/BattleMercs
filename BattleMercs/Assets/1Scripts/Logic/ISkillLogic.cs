using UnityEngine;

namespace _1Scripts.Logic
{
   public interface ISkillLogic
   {
      ISkillInformation SkillInformation { get; }
      ISkillAttributes SkillAttributes { get; }

   }
}
