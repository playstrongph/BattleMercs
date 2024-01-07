using System.Collections;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface ICoroutineTree
    {
        ICoroutineNode Root { get; set; }
        MonoBehaviour MonoBehaviourReference { get; set; }
        ICoroutineNode CurrentNode { get; set; }

        ICoroutineQueue CoroutineQueue { get; set; }

        /// <summary>
        /// Returns true if the tree is empty, false otherwise.
        /// </summary>
        bool Empty { get; }

        void EndSequence();

        /// <summary>
        /// Add a coroutine as child of the current node.
        /// Current node is the node being processed
        /// </summary>
        /// <param name="value">Coroutine to add.</param>
        void AddCurrent(IEnumerator value);

        /// <summary>
        /// Add a coroutine as a child of the root node.
        /// </summary>
        /// <param name="value">Coroutine to add.</param>
        void AddRoot(IEnumerator value);

        /*/// <summary>
        /// Add a coroutine as a sibling of the current node
        /// This is processed after all children of the current node are done
        /// </summary>
        /// <param name="value">Coroutine to add.</param>
        void AddSibling(IEnumerator value);
        */

        /// <summary>
        /// Removes all pending coroutines.
        /// </summary>
        void CleanUp();
    }
}