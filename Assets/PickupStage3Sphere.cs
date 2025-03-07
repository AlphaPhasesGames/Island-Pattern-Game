using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage3Sphere : MonoBehaviour
    {
        public Stage3CollectablesManager collectMan;
        public GameObject sphere;
        public Button sphereButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") )
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                sphereButton.gameObject.SetActive(true);
                sphere.gameObject.SetActive(false);
            }

            if (other.CompareTag("Club"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                sphereButton.gameObject.SetActive(true);
                sphere.gameObject.SetActive(false);
            }
            
        }
    }
}
