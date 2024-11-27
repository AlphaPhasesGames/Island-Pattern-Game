using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Hex2 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject hex2;
        public Button hex2Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                hex2Button.gameObject.SetActive(true);
                hex2.gameObject.SetActive(false);
            }


        }
    }
}
