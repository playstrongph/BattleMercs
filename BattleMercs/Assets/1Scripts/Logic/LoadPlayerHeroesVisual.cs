using UnityEngine;

namespace _1Scripts.Logic
{
   public class LoadPlayerHeroesVisual : MonoBehaviour, ILoadPlayerHeroesVisual
   {
      #region VARIABLES
#pragma warning disable 0649
       
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerLogic))] private Object playerLogic;
      
#pragma warning restore 0649
      #endregion

      #region PROPERTIES

      private IPlayerLogic PlayerLogic => playerLogic as IPlayerLogic;

      #endregion

      #region METHODS

      public void LoadHeroesVisual()
      {
          for (int i = 0; i < PlayerLogic.PlayerHeroes.Count; i++)
          {
              var heroLogic = PlayerLogic.PlayerHeroes[i];
              var heroVisual = PlayerLogic.PlayerVisualReference.HeroVisualsList[i];
              
              //Set References
              heroLogic.HeroVisualReference = heroVisual;
              heroVisual.HeroLogicReference = heroLogic;

              heroVisual.UpdateAllHeroVisualComponents(heroLogic);
          }
      }

      #endregion
   }
}
