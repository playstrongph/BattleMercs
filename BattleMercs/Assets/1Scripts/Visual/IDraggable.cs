using UnityEngine;

namespace _1Scripts.Visual
{
    public interface IDraggable
    {
        BoxCollider ArrowCollider { get; }

        /// <summary>
        /// Enables draggable script
        /// specifically, the update method
        /// </summary>
        void EnableDraggable();

        /// <summary>
        /// Disables the draggable script
        /// prevents the Update method from running continuously
        /// </summary>
        void DisableDraggable();
    }
}