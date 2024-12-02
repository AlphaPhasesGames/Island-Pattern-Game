using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2ReturnObjects : MonoBehaviour
    {
        public GameObject square1Object;
        public GameObject square2Object;
        public GameObject square3Object;
        public GameObject circle1Object;
        public GameObject circle2Object;
        public GameObject circle3Object;
        public GameObject triangle1Object;
        public GameObject triangle2Object;
        public GameObject triangle3Object;
        public GameObject hex1Object;
        public GameObject hex2Object;
        public GameObject hex3Object;

        public GameObject square1Respawn;
        public GameObject square2Respawn;
        public GameObject square3Respawn;
        public GameObject circle1Respawn;
        public GameObject circle2Respawn;
        public GameObject circle3Respawn;
        public GameObject triangelRespawn;
        public GameObject triange2Respawn;
        public GameObject triange3Respawn;
        public GameObject hex1Respawn;
        public GameObject hex2Respawn;
        public GameObject hex3Respawn;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Square"))
            {
                square1Object.transform.position = square1Respawn.transform.position;
            }

            if (other.CompareTag("Square2"))
            {
                square2Object.transform.position = square2Respawn.transform.position;
            }
            if (other.CompareTag("Square3"))
            {
                square3Object.transform.position = square3Respawn.transform.position;
            }
            if (other.CompareTag("Circle1"))
            {
                circle1Object.transform.position = circle1Respawn.transform.position;
            }

            if (other.CompareTag("Circle2"))
            {
                circle2Object.transform.position = circle2Respawn.transform.position;
            }

            if (other.CompareTag("Circle3"))
            {
                circle3Object.transform.position = circle3Respawn.transform.position;
            }

            if (other.CompareTag("Tri1"))
            {
                triangle1Object.transform.position = triangelRespawn.transform.position;
            }

            if (other.CompareTag("Tri2"))
            {
                triangle2Object.transform.position = triange2Respawn.transform.position;
            }

            if (other.CompareTag("Tri3"))
            {
                triangle3Object.transform.position = triange3Respawn.transform.position;
            }

            if (other.CompareTag("Hex1"))
            {
                hex1Object.transform.position = hex1Respawn.transform.position;
            }

            if (other.CompareTag("Hex2"))
            {
                hex2Object.transform.position = hex2Respawn.transform.position;
            }
            if (other.CompareTag("Hex2"))
            {
                hex3Object.transform.position = hex3Respawn.transform.position;
            }

        }
    }
}
