using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Hex1 : MonoBehaviour
    {
        public S2S2CollectionsManager collectMan;
        public GameObject hex1;
        public Button hex1Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                hex1Button.gameObject.SetActive(true);
                hex1.gameObject.SetActive(false);
            }


        }
    }
}
