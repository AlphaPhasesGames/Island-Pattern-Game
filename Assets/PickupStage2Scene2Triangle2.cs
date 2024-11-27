using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Triangle2 : MonoBehaviour
    {
        // public Stage2Scene1Collectables collectMan;
        public GameObject tri2;
        public Button tri2Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                // collectMan.collectableCount++;
                tri2Button.gameObject.SetActive(true);
                tri2.gameObject.SetActive(false);
            }


        }

    }
}
