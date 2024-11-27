using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Triangle3 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject tri3;
        public Button tri3Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                tri3Button.gameObject.SetActive(true);
                tri3.gameObject.SetActive(false);
            }


        }

    }
}
