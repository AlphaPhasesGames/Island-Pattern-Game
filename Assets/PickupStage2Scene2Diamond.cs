using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene2Diamond : MonoBehaviour
    {
        public S2S2CollectionsManager collectMan;
        public GameObject diamond3;
        public Button diamond3Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                diamond3Button.gameObject.SetActive(true);
                diamond3.gameObject.SetActive(false);
            }


        }
    }
}
