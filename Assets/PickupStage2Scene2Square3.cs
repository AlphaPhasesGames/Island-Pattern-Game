using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Square3 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject square3;
        public Button square3Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                square3Button.gameObject.SetActive(true);
                square3.gameObject.SetActive(false);
            }


        }
    }
}
