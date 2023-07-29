namespace _1Scripts.Visual
{
    public interface IHeroSkillsVisual
    {
        ISkillPanelVisual ThreeSkillPanelVisual { get; }
        ISkillPanelVisual FourSkillPanelVisual { get; }
        IBattleSceneManagerVisual BattleSceneManagerVisual { get; }
        void ShowHeroSkillsVisual();
        void HideHeroSkillsVisual();
    }
}