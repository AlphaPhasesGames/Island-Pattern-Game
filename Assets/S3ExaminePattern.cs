using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S3ExaminePattern : MonoBehaviour
    {
        public Stage3TextMan textMan;
        public RobotController robCont;
        public Camera playerCam;
        public Camera patternCam;
        public Camera stairsCam;
        public BoxCollider thisCollider;

        public bool hasViewedPattern;
        public bool pathShowing;
        public GameObject stairsPath1;
        public GameObject robotToHide;
        public Button closeButton;
        private void Awake()
        {
            closeButton.onClick.AddListener(ClosePedastalVeiw);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                robCont.isCharActive = false;
                textMan.positionChanged = true;
                textMan.arrayPos = 9;
                playerCam.enabled = false;
                patternCam.enabled = true;
                closeButton.gameObject.SetActive(true);
                thisCollider.enabled = false;
                robCont.isCharActive = false;
                robotToHide.gameObject.SetActive(false);
            }
           
        }

        private void ClosePedastalVeiw()
        {
            textMan.positionChanged = true;
            robCont.isCharActive = true;
            playerCam.enabled = true;
            patternCam.enabled = false;
            closeButton.gameObject.SetActive(false);
            robCont.isCharActive = true;
            robotToHide.gameObject.SetActive(true);
            if (!pathShowing)
            {
              
                textMan.arrayPos = 13;
                pathShowing = true;
            }
        }
    }
}
