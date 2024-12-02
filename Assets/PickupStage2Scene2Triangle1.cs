using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Triangle1 : MonoBehaviour
    {
        public S2S2CollectionsManager collectMan;
        public GameObject tri1;
        public Button triButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                triButton.gameObject.SetActive(true);
                tri1.gameObject.SetActive(false);
            }


        }

    }
}
