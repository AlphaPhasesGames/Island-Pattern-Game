using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene1Cicle1 : MonoBehaviour
    {
        // public CollectablesManager collectMan;
        public GameObject circle1;
        public Button circleButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                //collectMan.collectableCount++;
                circleButton.gameObject.SetActive(true);
                circle1.gameObject.SetActive(false);
            }


        }

    }
}
