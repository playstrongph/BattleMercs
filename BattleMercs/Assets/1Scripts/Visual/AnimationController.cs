using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _1Scripts.Visual
{
   public class AnimationController : MonoBehaviour
   {
      #region VARIABLES
      
      #pragma warning disable 0649

      private Queue<Action> animationQueue = new Queue<Action>();
      private bool isPlaying = false;
      
      #pragma warning restore 0649

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      
     

      public void EnqueueAnimation(Action animationAction)
      {
         animationQueue.Enqueue(animationAction);

         // Start playing animations if not already playing
         if (!isPlaying)
         {
            StartCoroutine(PlayAnimations());
         }
      }
      
      private IEnumerator PlayAnimations()
      {
         isPlaying = true;

         while (animationQueue.Count > 0)
         {
            Action nextAnimation = animationQueue.Dequeue();
            nextAnimation.Invoke();

            // Wait for the animation to finish (you may adjust this based on your animation logic)
            yield return new WaitForSeconds(1.0f);
         }

         isPlaying = false;
      }


      #endregion
   }
}
