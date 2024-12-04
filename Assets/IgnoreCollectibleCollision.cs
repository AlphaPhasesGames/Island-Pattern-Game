using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class IgnoreCollectibleCollision : MonoBehaviour
    {
        public Collider clubCollider;  // Assign the club's Collider in the Inspector
        public Collider[] collectibleColliders;  // Assign all collectible colliders in the Inspector

        void Start()
        {
            foreach (Collider collectible in collectibleColliders)
            {
                Physics.IgnoreCollision(clubCollider, collectible);
            }
        }
    }
}
