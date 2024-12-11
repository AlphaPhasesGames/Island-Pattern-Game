using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S3ShowPath2 : MonoBehaviour
    {
        public Stage3TextMan textMan;
        public bool lookedAtOnce;
        public GameObject path2Stairs;
        public GameObject path2Boxes;

      
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!lookedAtOnce)
                {
                  
                    textMan.positionChanged = true;
                    textMan.arrayPos = 16;
                    lookedAtOnce = true;
                    path2Boxes.gameObject.SetActive(true);
                    path2Stairs.gameObject.SetActive(true);
                }

            }
        }
    }
}
