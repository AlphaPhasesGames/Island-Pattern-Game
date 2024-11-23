using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1ReturnObjects : MonoBehaviour
    {
        public GameObject squareObject;
        public GameObject circle1Object;
        public GameObject circle2Object;
        public GameObject triangle1Object;
        public GameObject triangle2Object;
        public GameObject triangle3Object;

        public GameObject squareRespawn;
        public GameObject circle1Respawn;
        public GameObject circle2Respawn;
        public GameObject triangelRespawn;
        public GameObject triange2Respawn;
        public GameObject triange3Respawn;



        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Square"))
            {
                squareObject.transform.position = squareRespawn.transform.position;
            }

            if (other.CompareTag("Circle1"))
            {
                circle1Object.transform.position = circle1Respawn.transform.position;
            }

            if (other.CompareTag("Circle2"))
            {
                circle2Object.transform.position = circle2Respawn.transform.position;
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
        }
    }
}
