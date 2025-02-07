using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2RuleTrigger : MonoBehaviour
    {
        public RobotController cahrCont;
        public Stage1Scene2TextMan textman;
        public Button ruleButton;
        public GameObject ruleObject;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textman.positionChanged = true; // Directly set positionChanged
                textman.arrayPos = 6;
                cahrCont.isCharActive = false;
                ruleButton.gameObject.SetActive(true);
                pickupSFX.Play();
                ruleObject.gameObject.SetActive(false);
            }
        }
    }
}
