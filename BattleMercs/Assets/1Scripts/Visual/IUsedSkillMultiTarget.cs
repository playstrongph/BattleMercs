using System.Collections.Generic;

namespace _1Scripts.Visual
{
    public interface IUsedSkillMultiTarget
    {
        List<IUsedSkillSingleTargetVisual> UsedSkillsList { get; }
    }
}