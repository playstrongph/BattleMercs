using _1Scripts.Logic;

namespace _1Scripts.Visual
{
    public interface IHeroSkillsVisual
    {
        ISkillPanelVisual ThreeSkillPanelVisual { get; }
        ISkillPanelVisual FourSkillPanelVisual { get; }
        IBattleSceneVisualManager BattleSceneVisualManager { get; }

        
        void ShowMainPlayerHeroSkillsPanelVisual(IHeroLogic referenceHeroLogic);
        void HideMainPlayerHeroSkillsVisual(IHeroLogic referenceHeroLogic);

        void ShowHeroSkillsVisual(IHeroLogic referenceHeroLogic);
    }
}