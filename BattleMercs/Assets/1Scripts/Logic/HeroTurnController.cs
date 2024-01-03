using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


namespace _1Scripts.Logic
{
   public class HeroTurnController : MonoBehaviour, IHeroTurnController
   {
      #region VARIABLES
#pragma warning disable 0649

       [Header("CONSTANTS")] 
       [SerializeField] private int speedEnergyTurnLimit = 1000;
       
       [Header("RUNTIME REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private Object activeTurnHero;
       
       [SerializeField][RequireInterfaceAttribute.RequireInterface(typeof(IHeroLogic))] private List<Object> heroesRankedBySpeedEnergy = new List<Object>();

       [Header("INSPECTOR REFERENCES")]
       [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneLogicManager))] private Object battleSceneLogicManager;
       
       
       

#pragma warning restore 0649

       #endregion

       #region PROPERTIES
       
       /// <summary>
       /// This is the threshold value that triggers a hero turn
       /// </summary>
       public int SpeedEnergyTurnLimit => speedEnergyTurnLimit;

       private IBattleSceneLogicManager BattleSceneLogicManager => battleSceneLogicManager as IBattleSceneLogicManager;

       /// <summary>
       /// hero currently taking a turn
       /// </summary>
       public IHeroLogic ActiveTurnHero
       {
           get => activeTurnHero as IHeroLogic;
           private set => activeTurnHero = value as Object;
       }

       #endregion

       #region METHODS
       
       /// <summary>
       /// 
       /// </summary>
       public void UpdateNextActiveHero()
       {
           var heroList = SortAllHeroesByHighestSpeedEnergy();
           
           ActiveTurnHero = heroList[0];
       }
       /// <summary>
       /// //Arrange all heroes according to SpeedEnergy, highest to lowest
       /// </summary>
       private List<IHeroLogic> SortAllHeroesByHighestSpeedEnergy()
       {
           var allHeroes = new List<IHeroLogic>(AllLivingHeroes());
           
           
           //Initial randomization and sorting - in case there's a hero with a starting speed energy greater than the speed energy limit
           ShuffleList(allHeroes);
           allHeroes.Sort((hero1, hero2) => hero2.HeroAttributes.SpeedEnergy.CompareTo(hero1.HeroAttributes.SpeedEnergy));
           
           while (allHeroes[0].HeroAttributes.SpeedEnergy < SpeedEnergyTurnLimit)
           {
               IncreaseAllHeroesSpeedEnergy(allHeroes); 
               
               ShuffleList(allHeroes);
               allHeroes.Sort((hero1, hero2) => hero2.HeroAttributes.SpeedEnergy.CompareTo(hero1.HeroAttributes.SpeedEnergy));
           }
           
           //Add to heroes ranked by speed so it can be seen in the inspector
           foreach (var hero in allHeroes)
           {
               heroesRankedBySpeedEnergy.Add(hero as Object);
           }
           
           return allHeroes;
       }

       private void IncreaseAllHeroesSpeedEnergy(List<IHeroLogic> allHeroes)
       {
           foreach (var hero in allHeroes)
           {
               hero.HeroAttributes.SpeedEnergy += hero.HeroAttributes.Speed;
               
               //TODO: Visual Animation
               
               //Visual Turn Order Text Update
               hero.HeroVisualReference.SetHeroTurnOrderTextVisual.UpdateHeroTurnOrderText( hero.HeroAttributes.SpeedEnergy);
           }   
       }

       private List<IHeroLogic> AllLivingHeroes()
       {
           var allPlayerHeroes = new List<IHeroLogic>(BattleSceneLogicManager.AllPlayersLogic.MainPlayer.GetComponent<IPlayerLogic>().AliveHeroes);
           var allEnemyHeroes = new List<IHeroLogic>(BattleSceneLogicManager.AllPlayersLogic.SelectedEnemyPlayer.GetComponent<IPlayerLogic>().AliveHeroes);
           var allHeroes = new List<IHeroLogic>();

           allHeroes.AddRange(allPlayerHeroes);
           allHeroes.AddRange(allEnemyHeroes);
           
           return allHeroes;
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
