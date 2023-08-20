using System.Collections.Generic;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillTargetAsset
    {
        List<IHeroLogic> GetSkillTargets(IHeroLogic heroLogic);
    }
}