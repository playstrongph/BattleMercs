using _1Scripts.Visual;

namespace _1Scripts.Logic
{
    public interface ISetHeroVisualAndLogicReferences
    {
        void SetReferences(IHeroLogic heroLogic, IHeroVisual heroVisual);
    }
}