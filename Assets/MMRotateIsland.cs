using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class MMRotateIsland : MonoBehaviour
    {
        // Rotation speed (degrees per second)
        public float rotationSpeed = 10f;

        void Update()
        {
            // Rotate the object around the Y-axis to the left (negative rotation)
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }
}
