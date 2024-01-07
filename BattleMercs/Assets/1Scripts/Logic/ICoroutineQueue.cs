using System.Collections;
using UnityEngine;

namespace _1Scripts.Logic
{
    public interface ICoroutineQueue
    {
        /// <summary>
        /// MonoBehavior reference as a coroutine runner
        /// </summary>
        MonoBehaviour MonoBehaviourReference { get; set; }

        /// <summary>
        /// Add coroutine to Coroutine Queue
        /// </summary>
        /// <param name="coroutine"></param>
        void AddToCoroutineQueue(IEnumerator coroutine);

        /// <summary>
        /// Marker for the end of a coroutine method and triggers
        /// the dequeue of the next coroutine in the queue
        /// </summary>
        /// <returns></returns>
        bool CoroutineCompleted()  //TODO:Is this better named as PlayCoroutineQueueCommands?
            ;
    }
}