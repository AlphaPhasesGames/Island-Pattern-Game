using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage1Scene1RulePageTirgger : MonoBehaviour
    {
        public CharacterController cahrCont;
        public Stage1Scene1TextMan textman;
        public Button ruleButton;
        public GameObject ruleObject;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            textman.arrayPos = 16;
            cahrCont.enabled = false;
            ruleButton.gameObject.SetActive(true);
            pickupSFX.Play();
            ruleObject.gameObject.SetActive(false);

        }
    }
}
