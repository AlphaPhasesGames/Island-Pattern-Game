using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene2Sphere3 : MonoBehaviour
    {
        public Stage1Scene2CollectablesManager collectMan;
        public GameObject sphere3;
        public Button sphere3Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphere3Button.gameObject.SetActive(true);
            sphere3.gameObject.SetActive(false);

        }
    }
}
