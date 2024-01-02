using System.Collections.Generic;
using UnityEngine;


namespace _1Scripts.Logic
{
   public class HeroTurnController : MonoBehaviour
   {
      #region VARIABLES
#pragma warning disable 0649

       [Header("RUNTIME REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object activeTurnHero;

       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> heroSpeedEnergyRanking = new List<Object>();

       [Header("INSPECTOR REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;
       
       

#pragma warning restore 0649

       #endregion

       #region PROPERTIES

       private IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;
       
       /// <summary>
       /// hero currently taking a turn
       /// </summary>
       public IHeroLogic ActiveTurnHero => activeTurnHero as IHeroLogic;
        
       /// <summary>
       /// Hero's arranged according to speed energy, from highest to lowest
       /// </summary>
       public List<IHeroLogic> HeroSpeedEnergyRanking
       {
           get
           {
               var newList = new List<IHeroLogic>();
               foreach (var hero in heroSpeedEnergyRanking)
               {
                   newList.Add(hero as IHeroLogic);
               }
               
               //Randomize the list first in the case of heroes with the same speed energy
               ShuffleList(newList);
               
               // Sort the list by 'Speed' in descending order
               newList.Sort((hero1, hero2) => hero2.HeroAttributes.SpeedEnergy.CompareTo(hero1.HeroAttributes.Speed));

               return newList;
           }
       }

       #endregion

       #region METHODS
       
       
       private void ShuffleList<T>(List<T> list)
       {
           var n = list.Count;
           for (var i = n - 1; i > 0; i--)
           {
               var randomIndex = Random.Range(0, i + 1);
               (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
           }
       }


       #endregion
   }
}
