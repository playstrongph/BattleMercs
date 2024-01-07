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
       /// Coroutine queue variable for the
       /// CoroutineQueue constructor
       /// </summary>
       private readonly Queue<IEnumerator> _queue;

       /// <summary>
       /// Initial state for coroutine queue's
       /// </summary>
       private bool _playingQueue = false;
       
#pragma warning restore 0649
      #endregion
        
      #region PROPERTIES

      /// <summary>
      /// MonoBehavior reference as a coroutine runner
      /// </summary>
      public MonoBehaviour MonoBehaviourReference { get; set; }

      #endregion
        
      #region METHODS

      /// <summary>
      /// CoroutineQueue constructor
      /// </summary>
      public CoroutineQueue()
      {
          _queue = new Queue<IEnumerator>();
      }
      
      /// <summary>
      /// Executes the first coroutine in the queue
      /// </summary>
      private void PlayFirstCommandFromQueue()
      {
          _playingQueue = true;             
          MonoBehaviourReference.StartCoroutine(_queue.Dequeue());     
       
      }
      
      /// <summary>
      /// Add coroutine to Coroutine Queue
      /// </summary>
      /// <param name="coroutine"></param>
      public void AddToCoroutineQueue(IEnumerator coroutine)
      {
          _queue.Enqueue(coroutine);
        
          if (!_playingQueue)
              PlayFirstCommandFromQueue();

      }
      
      /// <summary>
      /// Marker for the end of a coroutine method and triggers
      /// the dequeue of the next coroutine in the queue
      /// </summary>
      /// <returns></returns>
      public bool CoroutineCompleted()  //TODO:Is this better named as PlayCoroutineQueueCommands?
      {
          if(_queue.Count > 0)
          {
              PlayFirstCommandFromQueue();
          }else
          {
              _playingQueue = false;
          }

          return true;
      }

      #endregion
   }
}
