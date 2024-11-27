using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Square1 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject square1;
        public Button square1Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                square1Button.gameObject.SetActive(true);
                square1.gameObject.SetActive(false);
            }


        }
    }
}
