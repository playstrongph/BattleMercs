using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace _1Scripts.Visual
{
   public class SkillTargetingVisual : MonoBehaviour, ISkillTargetingVisual
   {
      #region VARIABLES
      
      [Header("Inspector References")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManagerVisual))] private Object battleSceneManagerVisual = null;
      
      [Header("Components")]
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISelectSkillTargetVisual))] private Object selectSkillTargetVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IArrowLineAndCrossHairVisual))] private Object arrowLineAndCrossHairVisual = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable = null;

      [Header("Transforms")] 
      [SerializeField] private Transform crossHair = null;
      [SerializeField] private Transform arrow = null;
      [SerializeField] private List<Transform> nodes = new List<Transform>();
      
      [Header("Images")] 
      [SerializeField] private Image crossHairImage = null;
      [SerializeField] private Image arrowImage = null;
      [SerializeField] private List<Image> nodesImage = new List<Image>();
      
      //Other variables

      private Vector3 SkillTargetingOrigin { get; set; }

      #endregion

      #region PROPERTIES
      public IBattleSceneManagerVisual BattleSceneManagerVisual => battleSceneManagerVisual as IBattleSceneManagerVisual;
      public ISelectSkillTargetVisual SelectSkillTargetVisual => selectSkillTargetVisual as ISelectSkillTargetVisual;
      public IArrowLineAndCrossHairVisual ArrowLineAndCrossHairVisual => arrowLineAndCrossHairVisual as IArrowLineAndCrossHairVisual;
      public IDraggable Draggable => draggable as IDraggable;
      public Transform CrossHair => crossHair;
      public Transform Arrow => arrow;
      public List<Transform> Nodes => nodes;

      public Transform ThisTransform => transform;


      public Image CrossHairImage => crossHairImage;
      public Image ArrowImage => arrowImage;
      public List<Image> NodesImage => nodesImage;


      #endregion

      #region METHODS

      private void Awake()
      {
         SkillTargetingOrigin = transform.position;
      }
      
      /// <summary>
      /// Resets the Skill Targeting Visual to original position
      /// </summary>
      public void ResetPositionToOrigin()
      {
         ThisTransform.position = SkillTargetingOrigin;
      }

      #endregion
   }
}
