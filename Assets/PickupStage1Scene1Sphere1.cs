using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere1 : MonoBehaviour
    {
        public CollectablesManager collectMan;
        public GameObject sphere1;
        public Button sphereButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphereButton.gameObject.SetActive(true);
            sphere1.gameObject.SetActive(false);

        }

    }
}
