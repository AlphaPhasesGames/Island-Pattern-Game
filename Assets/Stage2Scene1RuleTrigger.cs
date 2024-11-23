using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1RuleTrigger : MonoBehaviour
    {
        public RobotController cahrCont;
        public Stage2Scene1TextMan textman;
        public Button ruleButton;
        public GameObject ruleObject;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            textman.positionChanged = true; // Directly set positionChanged
            textman.arrayPos = 8;
          //  cahrCont.isCharActive = false;
            ruleButton.gameObject.SetActive(true);
            pickupSFX.Play();
            ruleObject.gameObject.SetActive(false);

        }
    }
}
