using System.Numerics;
using _1Scripts.Visual;
using Vector3 = UnityEngine.Vector3;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IPlayerAllianceAsset
    {

        void DisplayHeroSkills(IHeroSkillsVisual heroSkillsVisual, IHeroLogic heroLogic);

        void UpdateSelectedHeroVisual(ISelectHeroVisual selectHeroVisual);


    }
}