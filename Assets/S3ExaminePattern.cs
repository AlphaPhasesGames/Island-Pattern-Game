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
            }
           
        }

        private void ClosePedastalVeiw()
        {
            textMan.positionChanged = true;
            robCont.isCharActive = true;
            playerCam.enabled = true;
            patternCam.enabled = false;
            closeButton.gameObject.SetActive(false);
         
            if (!pathShowing)
            {
                playerCam.enabled = false;
                stairsCam.enabled = true;
                textMan.arrayPos = 13;
                stairsPath1.gameObject.SetActive(true);
                pathShowing = true;
            }
        }
    }
}
