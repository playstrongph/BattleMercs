using System.Numerics;
using _1Scripts.Visual;
using Vector3 = UnityEngine.Vector3;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IPlayerAllianceAsset
    {

        void DisplayHeroSkills(IHeroSkillsVisual heroSkillsVisual, IHeroLogic heroLogic);

        void ScaleDownHero(IHeroVisual heroVisual);

        void ScaleUpHero(IHeroVisual heroVisual, Vector3 newScale);
    }
}