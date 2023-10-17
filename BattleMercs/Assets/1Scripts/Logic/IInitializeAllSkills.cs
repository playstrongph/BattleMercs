using _1Scripts.Logic.SOLogicScripts;

namespace _1Scripts.Logic
{
    public interface IInitializeAllSkills
    {

        void LoadAllSkills(IBattleSceneLogicManager logicManager, IHeroLogic heroLogic, IHeroAsset heroAsset);
    }
}