using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class CoroutineNode : ICoroutineNode
   {
      #region VARIABLES
      #pragma warning disable 0649
       
      /// <summary>
      /// List of children nodes.
      /// </summary>
      private readonly List<CoroutineNode> _children = new List<CoroutineNode>();


#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES
      
      /// <summary>
      /// Coroutine used in the coroutine tree process node sequence
      /// </summary>
      public IEnumerator Value { get; private set; }
      
      
      
      /// <summary>
      /// Accessor for a children node.
      /// Does not check for index validity.
      /// </summary>
      /// <param name="i">Index of wanted child.</param>
      /// <returns></returns>
      public CoroutineNode this[int i] => _children[i];
      
      /// <summary>
      /// Parent node.
      /// Is null for root of a tree.
      /// </summary>
      public CoroutineNode Parent { get; private set; }
      
      /// <summary>
      /// Number of children this node has.
      /// </summary>
      public int ChildrenCount => _children.Count;
      
      
        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Coroutine Node
      /// </summary>
      /// <param name="value"></param>
      public CoroutineNode(IEnumerator value)
      {
         Value = value;
      } 
      
      /// <summary>
      /// Add a coroutine as a child of the node.
      /// </summary>
      /// <param name="coroutine">Coroutine to add.</param>
      /// <returns></returns>
      public CoroutineNode AddChild(IEnumerator coroutine)
      {
         var node = new CoroutineNode(coroutine) { Parent = this };
         _children.Add(node);
         return node;
      }
        
      /// <summary>
      /// Remove all children of this node.
      /// </summary>
      public void ClearChildren()
      {
         _children.Clear();
      }

      #endregion
   }
}
