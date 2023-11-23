using _1Scripts.Visual;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IHeroElementAsset
    {
        void SetHeroClassColor(IHeroVisual heroVisual);

        void SetHeroPreviewClassColor(IHeroPreviewVisual heroPreviewVisual);


    }
}