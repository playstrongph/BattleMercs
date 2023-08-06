using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillTargetingVisual : MonoBehaviour
   {
      #region VARIABLES

      [Header("Transforms")] 
      [SerializeField] private Transform crossHair = null;
      [SerializeField] private Transform arrow = null;
      [SerializeField] private List<Transform> nodes = new List<Transform>();
    
      
      [Header("Images")] 
      [SerializeField] private Image crossHairImage = null;
      [SerializeField] private Image arrowImage = null;
      [SerializeField] private List<Image> nodesImage = new List<Image>();
    
      
     
      #endregion

      #region PROPERTIES

      public Transform CrossHair => crossHair;
      public Transform Arrow => arrow;
      private List<Transform> Nodes => nodes;
   
      
      public Image CrossHairImage => crossHairImage;
      public Image ArrowImage => arrowImage;
      private List<Image> NodesImage => nodesImage;
     
      
   
      

      #endregion

      #region METHODS



      #endregion
   }
}
