using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _1Scripts.Visual
{
   public class SkillTargetingVisual : MonoBehaviour, ISkillTargetingVisual
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;

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
      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;
      public Transform CrossHair => crossHair;
      public Transform Arrow => arrow;
      public List<Transform> Nodes => nodes;
   
      
      public Image CrossHairImage => crossHairImage;
      public Image ArrowImage => arrowImage;
      public List<Image> NodesImage => nodesImage;
     
      
   
      

      #endregion

      #region METHODS



      #endregion
   }
}
