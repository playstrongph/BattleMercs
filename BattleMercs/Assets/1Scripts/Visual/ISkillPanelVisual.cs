using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
    public interface ISkillPanelVisual
    {
        Image SkillPanelImage { get; }
        ISkillPanelFrames SkillPanelFrames { get; }
        List<ISkillVisual> SkillVisualList { get; }
        void ShowSkillPanel();
        void HideSkillPanel();

        Transform Transform { get; }
    }
}