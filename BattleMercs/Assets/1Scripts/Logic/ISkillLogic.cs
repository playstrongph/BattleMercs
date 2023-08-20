using UnityEngine;

namespace _1Scripts.Logic
{
   public interface ISkillLogic
   {
      string SkillNameLabel { get; set; }
      ISkillInformation SkillInformation { get; }
      ISkillAttributes SkillAttributes { get; }

   }
}
