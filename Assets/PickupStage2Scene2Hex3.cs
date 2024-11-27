using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Hex3 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject hex3;
        public Button hex3Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                hex3Button.gameObject.SetActive(true);
                hex3.gameObject.SetActive(false);
            }


        }
    }
}
