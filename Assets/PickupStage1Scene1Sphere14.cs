using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere14 : MonoBehaviour
    {
        public GameObject sphere14;
        public Button sphereButton;
        public AudioSource pickupSFX;
        public CollectablesManager collectMan;

        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphereButton.gameObject.SetActive(true);
            sphere14.gameObject.SetActive(false);

        }
    }
}
