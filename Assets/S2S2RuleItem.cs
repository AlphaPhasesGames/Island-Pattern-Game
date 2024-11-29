using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S2S2RuleItem : MonoBehaviour
    {
        public RobotController cahrCont;
        public Stage2Scene2TextMan textman;
        public Button ruleButton;
        public GameObject ruleObject;
        public AudioSource pickupSFX;
        public bool hasRule;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textman.positionChanged = true; // Directly set positionChanged
                textman.arrayPos = 5;
                //  cahrCont.isCharActive = false;
                ruleButton.gameObject.SetActive(true);
                pickupSFX.Play();
                ruleObject.gameObject.SetActive(false);
                hasRule = true;
            }
          
        }
    }
}
