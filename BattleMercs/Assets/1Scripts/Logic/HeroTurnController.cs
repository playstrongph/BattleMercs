using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


namespace _1Scripts.Logic
{
   public class HeroTurnController : MonoBehaviour
   {
      #region VARIABLES
#pragma warning disable 0649

       [Header("CONSTANTS")] 
       [SerializeField] private int speedEnergyTurnLimit = 1000;
       
       [Header("RUNTIME REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object activeTurnHero;
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> heroesRankedBySpeed = new List<Object>();

       [Header("INSPECTOR REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;
       
       
       

#pragma warning restore 0649

       #endregion

       #region PROPERTIES
       
       /// <summary>
       /// This is the threshold value that triggers a hero turn
       /// </summary>
       private int SpeedEnergyTurnLimit => speedEnergyTurnLimit;

       private IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;

       /// <summary>
       /// hero currently taking a turn
       /// </summary>
       public IHeroLogic ActiveTurnHero
       {
           get => activeTurnHero as IHeroLogic;
           private set => activeTurnHero = value as Object;
       }

       /// <summary>
       /// Hero's arranged according to speed energy, from highest to lowest
       /// </summary>
       private List<IHeroLogic> HeroesRankedBySpeed
       {
           get
           {
               var newList = new List<IHeroLogic>();
               foreach (var hero in heroesRankedBySpeed)
               {
                   newList.Add(hero as IHeroLogic);
               }
               return newList;
           }
       }

       #endregion

       #region METHODS
       
       /// <summary>
       /// 
       /// </summary>
       public void UpdateNextActiveHero()
       {
           //Arrange all heroes according to SpeedEnergy, highest to lowest
           SortAllHeroesByHighestSpeedEnergy();
           
           //The first hero in heroes ranked by speed has the highest speed
           var nextActiveHero = HeroesRankedBySpeed[0];

           if (nextActiveHero.HeroAttributes.Speed >= SpeedEnergyTurnLimit)
           {
               ActiveTurnHero = nextActiveHero;
               //TODO: ActiveHeroTakesATurn
           }
           else
           {
               //Increase all Heroes speed energy
               IncreaseAllHeroesSpeedEnergy();

               //Repeat this method
               UpdateNextActiveHero();
           }
       }



       private void IncreaseAllHeroesSpeedEnergy()
       {
           foreach (var hero in HeroesRankedBySpeed)
           {
               //TODO: Check in the future if there's a debuff that prevents speed energy increase
               hero.HeroAttributes.SpeedEnergy += hero.HeroAttributes.Speed;
               
               //TODO: Visual and Animation updates on heroTurnBar and hero speed energy display
           }
           
       }

       /// <summary>
       /// //Arrange all heroes according to SpeedEnergy, highest to lowest
       /// </summary>
       private void SortAllHeroesByHighestSpeedEnergy()
       {
           var allPlayerHeroes = BattleSceneLogicManager.AllPlayersLogic.MainPlayer.GetComponent<IPlayerLogic>().AliveHeroes;
           var allEnemyHeroes = BattleSceneLogicManager.AllPlayersLogic.SelectedEnemyPlayer.GetComponent<IPlayerLogic>().AliveHeroes;

           var allHeroes = new List<IHeroLogic>();
           
           allHeroes.Clear();
           
           allHeroes.AddRange(allPlayerHeroes);
           allHeroes.AddRange(allEnemyHeroes);
           
           //randomize hero order before sorting
           ShuffleList(allHeroes);
           
           // Sort the list by 'Speed' in descending order
           allHeroes.Sort((hero1, hero2) => hero2.HeroAttributes.SpeedEnergy.CompareTo(hero1.HeroAttributes.Speed));
           
           //Add to heroes ranked by speed so it can be seen in the inspector
           foreach (var hero in allHeroes)
           {
               heroesRankedBySpeed.Add(hero as Object);
           }
       }







       //GENERIC METHODS
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
