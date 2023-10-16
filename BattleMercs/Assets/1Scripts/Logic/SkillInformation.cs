using UnityEngine;

namespace _1Scripts.Logic
{
   public class SkillInformation : MonoBehaviour, ISkillInformation
   {
      #region VARIABLES
      
#pragma warning disable 0649
      [SerializeField] private string skillName;
      [TextArea(5, 5)] [SerializeField] private string skillDescription;
      [SerializeField] private Sprite skillSprite;
         
      [Header("Runtime References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object casterHero;
         
#pragma warning restore 0649
        

      #endregion
        
      #region PROPERTIES

      public string SkillName { get => skillName; set => skillName = value; }
      public string SkillDescription { get => skillDescription; set => skillDescription = value; }
      public Sprite SkillSprite { get => skillSprite; set => skillSprite = value; }
         
      public IHeroLogic CasterHero
      {
          get => casterHero as IHeroLogic;
          set => casterHero = value as Object;
      }  

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
