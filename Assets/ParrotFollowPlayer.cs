using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class ParrotFollowPlayer : MonoBehaviour
    {
        public Transform player;             // Reference to the player's transform
        public float delayInSeconds = 0.1f;  // Delay time (in seconds)
        public float smoothSpeed = 5f;       // Smoothing factor (higher = faster interpolation)

        private Queue<Vector3> positionHistory;  // Stores the player's past positions
        private int frameDelay;                  // Calculated based on delay and frame rate

        void Start()
        {
            // Initialize the position history queue
            positionHistory = new Queue<Vector3>();

            // Calculate frame delay based on delay time and current frame rate
            frameDelay = Mathf.Max(1, Mathf.RoundToInt(delayInSeconds / Time.fixedDeltaTime));
        }

        void FixedUpdate()
        {
            // Add the player's current position to the queue
            positionHistory.Enqueue(player.position);
            this.gameObject.transform.rotation = player.transform.rotation;
            // Remove the oldest position if the queue exceeds the desired frame delay
            if (positionHistory.Count > frameDelay)
            {
                // Get the delayed position
                Vector3 delayedPosition = positionHistory.Dequeue();

                // Smoothly interpolate towards the delayed position
                transform.position = Vector3.Lerp(transform.position, delayedPosition, smoothSpeed * Time.fixedDeltaTime);
            }
        }
    }
}