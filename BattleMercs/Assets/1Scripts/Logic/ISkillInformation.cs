using UnityEngine;

namespace _1Scripts.Logic
{
   public interface ISkillInformation
   {

      string SkillName { get; set; }
      string SkillDescription { get; set; }
      Sprite SkillSprite { get; set; }
      IHeroLogic CasterHero { get; set; }


   }
}
