using _1Scripts.Logic;
using TMPro;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetHeroTurnOrderTextVisual : MonoBehaviour, ISetHeroTurnOrderTextVisual
   {
      #region VARIABLES
      
      #pragma warning disable 0649
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisualReference;
      [SerializeField] private int maxPercentage = 100;
      
      #pragma warning restore 0649


      #endregion

      #region PROPERTIES

      private IHeroVisual HeroVisualReference => heroVisualReference as IHeroVisual;


      #endregion

      #region METHODS

      public void UpdateHeroTurnOrderText(int speedEnergy)
      {
         var speedEnergyLimit = HeroVisualReference.PlayerVisualReference.BattleSceneVisualManager.BattleSceneLogicManager.HeroTurnController.SpeedEnergyTurnLimit;

         // ReSharper disable once PossibleLossOfFraction
         var speedEnergyPercentage = Mathf.RoundToInt(100*speedEnergy/(speedEnergyLimit));
         
         speedEnergyPercentage = Mathf.Min(speedEnergyPercentage, maxPercentage);

         HeroVisualReference.TurnOrderText.text = speedEnergyPercentage.ToString()+"%";
      }

      #endregion
   }
}
