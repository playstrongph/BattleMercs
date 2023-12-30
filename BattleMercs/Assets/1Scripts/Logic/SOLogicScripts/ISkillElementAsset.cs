using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface ISkillElementAsset
    {
        void SetSkillElement();

        void SetSkillPreviewClassColor(ISkillPreviewVisual skillPreview);

        void UpdateSkillPreviewElementText(ISkillPreviewVisual skillPreviewVisual);
    }
}