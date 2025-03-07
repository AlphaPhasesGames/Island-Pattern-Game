using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Circle2 : MonoBehaviour
    {
        public S2S2CollectionsManager collectMan;
        public GameObject circle2;
        public Button circleButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                circleButton.gameObject.SetActive(true);
                circle2.gameObject.SetActive(false);
            }


        }

    }
}

