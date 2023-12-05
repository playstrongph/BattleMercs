using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IHeroElementAsset
    {
        void SetHeroPreviewSkillClassColor(IHeroPreviewSkill heroPreviewSkill);

        void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual);

        void SetHeroPreviewElementText(IHeroPreviewSkill heroPreviewSkill);


    }
}