using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S3DockTrigger : MonoBehaviour
    {
        public Stage3TextMan textMan;
        public Camera dockCam;
        public Camera playerCam;
        public bool lookedAtOnce;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!lookedAtOnce)
                {
                    dockCam.enabled = true;
                    playerCam.enabled = false;
                    textMan.positionChanged = true;
                    textMan.arrayPos = 4;
                    lookedAtOnce = true;
                }
              
            }
        }
    }
}
