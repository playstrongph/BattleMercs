namespace _1Scripts.Visual
{
    public interface ISetSkillPreviewComponents
    {
        void UpdateSkillPreviewGameObjectName(string previewGameObjectName);  
        void UpdateSkillPreviewFrame();  //For Update
        void UpdateSkillPreviewGraphic(); //For Update
        void UpdateSkillPreviewCooldownGraphic(); //For Update
        void UpdateSkillPreviewNameText(); //For Update
        void UpdateSkillPreviewElementText(); //For Update
        void UpdateSkillPreviewDescriptionText(); //For Update
        void UpdateSkillPreviewCooldownText( ); //For Update
        void UpdateSkillPreviewSpeedText( ); //For Update
    }
}