using UnityEngine;

namespace _1Scripts.Visual
{
   public class SetHeroVisuals : MonoBehaviour
   {
      #region VARIABLES

   #pragma warning disable 0649
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual;
      
      
#pragma warning restore 0649

      #endregion

      #region PROPERTIES
      
      private IHeroVisual HeroVisual => heroVisual as IHeroVisual;


      #endregion

      #region METHODS

      public void ShowHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }
      
      public void HideHeroGlowVisual()
      {
         //TODO: Hero Glow is based on skill targeting
      }
      
      /// <summary>
      /// Hero Frame depends on the hero Element
      /// </summary>
      public void SetHeroFrameColorVisual()
      {
         var heroLogic = HeroVisual.HeroLogicReference;
         
         heroLogic.HeroInformation.HeroElement.SetClassColor(heroLogic);
      }

      public void SetArmorVisual(int armorValue)
      {
         var armorImage = HeroVisual.ArmorImage;
         var armorText = HeroVisual.ArmorText;

         if (armorValue > 0)
         {
            armorImage.enabled = true;
            armorText.enabled = true;

            armorText.text = armorValue.ToString();
         }
         else
         {
            armorImage.enabled = false;
            armorText.enabled = false;
         }
      }



      #endregion
   }
}
