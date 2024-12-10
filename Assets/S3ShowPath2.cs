using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S3ShowPath2 : MonoBehaviour
    {
        public Stage3TextMan textMan;
        public Camera stairCam;
        public Camera playerCam;
        public bool lookedAtOnce;
        public GameObject path2Stairs;
        public GameObject path2Boxes;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!lookedAtOnce)
                {
                    stairCam.enabled = true;
                    playerCam.enabled = false;
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
