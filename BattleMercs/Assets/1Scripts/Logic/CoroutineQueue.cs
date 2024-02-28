using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class CoroutineQueue : ICoroutineQueue
   {
      #region VARIABLES
#pragma warning disable 0649
       
       /// <summary>
       /// The coroutine queue 
       /// </summary>
       private readonly Queue<IEnumerator> _coroutineQueue;

       /// <summary>
       /// Variable to indicate a coroutine is currently playing
       /// </summary>
       private bool _playingQueue = false;
       
#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES

      /// <summary>
      /// MonoBehavior reference to enable StartCoroutine
      /// </summary>
      public MonoBehaviour MonoBehaviourReference { get; set; }

      #endregion
        
      #region METHODS

      /// <summary>
      /// CoroutineQueue constructor
      /// </summary>
      public CoroutineQueue()
      {
          _coroutineQueue = new Queue<IEnumerator>();
      }
      
      /// <summary>
      /// Coroutine Queue execution is always First-In, First-Out
      /// </summary>
      private void PlayFirstCoroutineInQueue()
      {
          //Set playing queue as true, so no other coroutines will play
          _playingQueue = true;
          
          //Start playing the first coroutine in the coroutine queue 
          MonoBehaviourReference.StartCoroutine(_coroutineQueue.Dequeue());     
       
      }
      
      /// <summary>
      /// Add coroutine to Coroutine Queue.  If no other coroutine is playing,
      /// play the coroutine immediately
      /// </summary>
      /// <param name="coroutine"></param>
      public void AddToCoroutineQueue(IEnumerator coroutine)
      {
          _coroutineQueue.Enqueue(coroutine);
        
          if (!_playingQueue)
              PlayFirstCoroutineInQueue();
      }
      
      /// <summary>
      /// Start Playing coroutines in queue
      /// TODO: Is this required?
      /// </summary>
      /// <returns></returns>
      public void PlayCoroutineInQueue()  //TODO:Is this better named as PlayCoroutineQueueCommands?
      {
          if(_coroutineQueue.Count > 0)
          {
              PlayFirstCoroutineInQueue();
          }else
          {
              _playingQueue = false;
          }

      }

      #endregion
   }
}
