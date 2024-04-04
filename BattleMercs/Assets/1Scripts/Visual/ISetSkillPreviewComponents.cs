using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Visual
{
    public interface ISetSkillPreviewComponents
    {
        void UpdateSkillPreviewGameObjectName(string skillName);  
        void UpdateSkillPreviewFrame(ISkillElementAsset skillElement);  
        void UpdateSkillPreviewGraphic(Sprite skillSprite); 
        void UpdateSkillPreviewCooldownGraphic(ISkillTypeAsset skillType); 
        void UpdateSkillPreviewNameText(string skillName); 
        void UpdateSkillPreviewElementText(ISkillElementAsset skillElement); 
        void UpdateSkillPreviewDescriptionText(string skillDescription);
        void UpdateSkillPreviewCooldownText(int baseSkillCooldown); 
        void UpdateSkillPreviewSpeedText(int baseSkillSpeed ); 
    }
}