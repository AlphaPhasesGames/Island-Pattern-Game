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
        public PatternQuestMain main;
        public GameObject dockTrigger;
        private void Awake()
        {
            main = GameObject.FindObjectOfType<PatternQuestMain>();
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!lookedAtOnce)
                {
                  
                    if (!main.s3DockFound)
                    {
                        dockCam.enabled = true;
                        playerCam.enabled = false;
                        textMan.positionChanged = true;
                        textMan.arrayPos = 4;
                        lookedAtOnce = true;
                        dockTrigger.gameObject.SetActive(false);
                    }
                  
                }
              
            }
        }
    }
}
