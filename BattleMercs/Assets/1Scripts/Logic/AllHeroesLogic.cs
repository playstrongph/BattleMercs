using System;
using System.Collections.Generic;
using UnityEngine;


namespace _1Scripts.Logic
{
   
   
   
   public class AllHeroesLogic : MonoBehaviour, IAllHeroesLogic
   {

      #region VARIABLES

      [SerializeField] private List<HeroLogic> allHeroes = new List<HeroLogic>();

      #endregion
      
      #region PROPERTIES
      
      public List<IHeroLogic> AllHeroes
      {
         get
         {
            var newList = new List<IHeroLogic>();
            foreach (var hero in allHeroes)
            {
               newList.Add(hero);
            }
            return newList;
         }
      }

      #endregion


      #region STRUCTS
      
      /// <summary>
      /// This is effectively the heroLogic Information
      /// </summary>

      [Serializable]
      public struct HeroLogic : IHeroLogic
      {
         #region StructVariables
         
         #pragma warning disable 0649
         
         //This is for changing the list element name only
         [SerializeField] private string listLabel;
         [SerializeField] private HeroInformation heroInformation;

         #pragma warning restore 0649

         #endregion

         #region StructProperties
         
         public IHeroInformation HeroInfo => heroInformation;
         public string ListLabel => listLabel;

         #endregion
      }
      
      [Serializable]
      //TODO: Create stand alone Interface for IHeroInformation
      public struct HeroInformation : IHeroInformation 
      {
         #region StructVariables
         
         #pragma warning disable 0649
         
         //[Header("Hero Information")]
         [SerializeField] private string heroName;
         [SerializeField] private int heroLevel;
         [SerializeField] private int heroStars;
         [SerializeField] private int heroCp;

         #pragma warning restore 0649 
         #endregion

         #region StructProperties

         public string HeroName => heroName;
         public int HeroLevel => heroLevel;
         public int HeroStars => heroStars;
         public int HeroCp => heroCp;

         #endregion
      }

      #endregion
        
      
      #region METHODS

     


      #endregion
   }
}
