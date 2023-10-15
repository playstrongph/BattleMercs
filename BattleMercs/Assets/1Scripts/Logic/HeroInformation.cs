using _1Scripts.Logic.SOLogicScripts;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class HeroInformation : MonoBehaviour, IHeroInformation
   {
      #region VARIABLES
      
#pragma warning disable 0649
         
      //[Header("Hero Information")]
      [SerializeField] private string heroName;
      [SerializeField] private int heroLevel;
      [SerializeField] private int heroStars;
      [SerializeField] private int cumulativePower;
         
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroElementAsset))] private Object heroElement;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private Object heroClass;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroZodiacAsset))] private Object heroZodiac;

#pragma warning restore 0649 
        

      #endregion
        
      #region PROPERTIES

      public string HeroName { get => heroName; set => heroName = value; }

      public int HeroLevel { get => heroLevel; set => heroLevel = value; }

      public int HeroStars { get => heroStars; set => heroStars = value; }

      public int CumulativePower { get => cumulativePower; set => cumulativePower = value; }

      public IHeroElementAsset HeroElement { get => heroElement as IHeroElementAsset; set => heroElement = value as Object; }

      public IHeroClassAsset HeroClass { get => heroClass as IHeroClassAsset; set => heroClass = value as Object; }
      
      public IHeroZodiacAsset HeroZodiac { get => heroZodiac as IHeroZodiacAsset; set => heroZodiac = value as Object; }

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
