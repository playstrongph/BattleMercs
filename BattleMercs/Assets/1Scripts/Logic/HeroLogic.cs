using System.Collections.Generic;
using _1Scripts.Visual;
using UnityEngine;


namespace _1Scripts.Logic
{
   public class HeroLogic : MonoBehaviour, IHeroLogic
   {
      #region VARIABLES
      
#pragma warning disable 0649
      
      [Header("COMPONENTS")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroInformation))] private Object heroInformation;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAttributes))] private Object heroAttributes;
      
      [Header("LOGIC REFERENCES")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object playerReference;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillLogic))] private List<Object> heroSkillsReference;

      [Header("VISUAL REFERENCES")] 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisualReference;
      
#pragma warning restore 0649


       #endregion

       #region PROPERTIES
       
       public IHeroInformation HeroInformation => heroInformation as IHeroInformation;
       public IHeroAttributes HeroAttributes => heroAttributes as IHeroAttributes;

       public IPlayerLogic PlayerReference
       {
           get => playerReference as IPlayerLogic;
           set => playerReference  = value as Object;
       }

       public List<ISkillLogic> HeroSkillsReference
       {
           get
           {
               var newList = new List<ISkillLogic>();
               foreach (var heroSKill in heroSkillsReference)
               {
                   newList.Add(heroSKill as ISkillLogic);
               }
               return newList;
           }
       }

       public IHeroVisual HeroVisualReference { get => heroVisualReference as IHeroVisual; set => heroVisualReference = value as Object; }

       public Transform Transform => this.transform;
    

       #endregion

       #region METHODS

       public void AddToHeroSkillsList(ISkillLogic skillLogic)
       {
           heroSkillsReference.Add(skillLogic as Object);
       }


       #endregion
   }
}
