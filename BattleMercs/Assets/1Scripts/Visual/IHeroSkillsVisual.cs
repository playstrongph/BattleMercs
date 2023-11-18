namespace _1Scripts.Visual
{
    public interface IHeroSkillsVisual
    {
        ISkillPanelVisual ThreeSkillPanelVisual { get; }
        ISkillPanelVisual FourSkillPanelVisual { get; }
        IBattleSceneVisualManager BattleSceneVisualManager { get; }
        void ShowHeroSkillsVisual();
        void HideHeroSkillsVisual();
    }
}