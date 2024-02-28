using System.Collections;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class CoroutineTree : MonoBehaviour, ICoroutineTree
   {
      #region VARIABLES
      
      #pragma warning disable 0649

      
      
      #pragma warning restore 0649

      #endregion
        
      #region PROPERTIES

      public ICoroutineNode Root { get; set; }

      public MonoBehaviour MonoBehaviourReference { get; set; }
      
      public ICoroutineNode CurrentNode { get; set; }

      public ICoroutineQueue CoroutineQueue { get; set; }

      #endregion

      #region METHODS
      
      /// <summary>
      /// Start processing of the tree.
      /// Called during the Ctor initialization "new CoroutineTree"
      /// TODO: Initialize elsewhere
      /// </summary>
      public void Start()
      {
         CoroutineQueue = new CoroutineQueue();
         CoroutineQueue.MonoBehaviourReference = MonoBehaviourReference;
      }
      
      /// <summary>
      /// New Coroutine tree constructor
      /// </summary>
      public CoroutineTree()
      {
         Root = new CoroutineNode(null);
         CurrentNode = Root;
      }
      
      /// <summary>
      /// Formerly known as 'end sequence'  This is called inside coroutines using logicTrees
      /// </summary>
      public void PlayCoroutineInQueue()
      {
         CoroutineQueue.PlayCoroutineInQueue();
      }
      
      /// <summary>
      /// Add a coroutine as child of the current node.
      /// Current node is the node being processed
      /// </summary>
      /// <param name="value">Coroutine to add.</param>
      public void AddCurrent(IEnumerator value)
      {
         CurrentNode.AddChild(value);

         MonoBehaviourReference.StartCoroutine(UpdateTree());
      }
      
      
      
      /// <summary>
      /// Add a coroutine as a child of the root node.
      /// </summary>
      /// <param name="value">Coroutine to add.</param>
      public void AddRoot(IEnumerator value)
      {
         Root.AddChild(value);
      }

      /// <summary>
      /// Returns true if the tree is empty, false otherwise.
      /// </summary>
      public bool Empty => Root == CurrentNode && Root.ChildrenCount <= 0;
      
      /// <summary>
      /// Coroutine that start the nodes sequentially under the root
      /// Has a recursive function to process nodes under the current node before proceeding with the other nodes
      /// Priority:  Node -> Children of the Node -> Siblings of the node
      /// </summary>
      private IEnumerator ProcessChildrenOfNode(ICoroutineNode node)
      {
         var i = 0;
         while(i < node.ChildrenCount)
         {
            // Node -> children -> siblings.
            CurrentNode = node[i];
            
            CoroutineQueue.AddToCoroutineQueue(node[i].Value);

            if (i >= node.ChildrenCount) yield break;

            if(node[i].ChildrenCount > 0)
            {
               // Recursion on children.
               yield return MonoBehaviourReference.StartCoroutine(ProcessChildrenOfNode(node[i]));
            }
            i++;
         }
            
         // Be defensive about clearing, do it only when everything was executed.
         if (node == Root)
         {
            CurrentNode = Root;
            Root.ClearChildren();
         }
      }
      /// <summary>
      /// Start processing the nodes of the roots
      /// </summary>
      /// <returns></returns>
      private IEnumerator UpdateTree()
      {
         if(CurrentNode == Root && Root.ChildrenCount > 0)
               yield return MonoBehaviourReference.StartCoroutine(ProcessChildrenOfNode(Root));
         else
               yield return null;
      }
      
      /// <summary>
      /// Removes all pending coroutines.
      /// </summary>
      public void CleanUp()
      {
         CurrentNode = Root;
         Root.ClearChildren();
      }


      #endregion
   }

   
}
