using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere1 : MonoBehaviour
    {
        public Stage1Scene1TextMan textMan;
        public GameObject collectablesUI;
        public CollectablesManager collectMan;
       // public GameObject sphere1;
        public Button sphereButton;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            textMan.positionChanged = true; // Directly set positionChanged
            textMan.arrayPos = 7;
            pickupSFX.Play();
            collectMan.collectableCount++;
            collectablesUI.gameObject.SetActive(true);
            sphereButton.gameObject.SetActive(true);
            Destroy(this.gameObject);
           // sphere1.gameObject.SetActive(false);

        }

    }
}
