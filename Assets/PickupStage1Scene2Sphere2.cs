using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene2Sphere2 : MonoBehaviour
    {
        public Stage1Scene2CollectablesManager collectMan;
        public GameObject sphere2;
        public Button sphere2Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphere2Button.gameObject.SetActive(true);
            sphere2.gameObject.SetActive(false);

        }
    }
}
