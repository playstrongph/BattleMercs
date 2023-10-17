using System.Collections.Generic;
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
      
      [Header("SET IN RUNTIME")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object playerReference;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillLogic))] private List<Object> heroSkills;
      
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

       public List<ISkillLogic> HeroSkills
       {
           get
           {
               var newList = new List<ISkillLogic>();
               foreach (var heroSKill in heroSkills)
               {
                   newList.Add(heroSKill as ISkillLogic);
               }
               return newList;
           }
       }

       public Transform Transform => this.transform;
    

       #endregion

       #region METHODS

       public void AddToHeroSkillsList(ISkillLogic skillLogic)
       {
           heroSkills.Add(skillLogic as Object);
       }


       #endregion
   }
}
