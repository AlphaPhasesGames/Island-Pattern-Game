using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage3FirstSphere : MonoBehaviour
    {
        public Stage3CollectablesManager collectMan;
        public Stage3TextMan textMan;
        public GameObject sphere;
        public Button sphereButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                textMan.positionChanged = true;
                textMan.arrayPos = 15;
                collectMan.collectableCount++;
                sphereButton.gameObject.SetActive(true);
                sphere.gameObject.SetActive(false);
            }
        }
    }
}
