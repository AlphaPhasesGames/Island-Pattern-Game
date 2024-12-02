using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Square2 : MonoBehaviour
    {
        public S2S2CollectionsManager collectMan;
        public GameObject square2;
        public Button square2Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                square2Button.gameObject.SetActive(true);
                square2.gameObject.SetActive(false);
            }


        }
    }
}
