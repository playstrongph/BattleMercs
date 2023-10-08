using System.Collections.Generic;

namespace _1Scripts.Logic.SOLogicScripts
{
    public interface IBattleSceneSettingsAsset
    {
        List<IPlayerAsset> Player { get; }
    }
}