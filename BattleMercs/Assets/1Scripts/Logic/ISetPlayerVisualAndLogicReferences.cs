using _1Scripts.Visual;

namespace _1Scripts.Logic
{
    public interface ISetPlayerVisualAndLogicReferences
    {
        void SetReferences(IPlayerLogic playerLogic, IPlayerVisual playerVisual);
    }
}