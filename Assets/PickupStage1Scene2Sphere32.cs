using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene2Sphere32 : MonoBehaviour
    {
        public Stage1Scene2CollectablesManager collectMan;
        public GameObject sphere32;
        public Button sphere32Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphere32Button.gameObject.SetActive(true);
            sphere32.gameObject.SetActive(false);
        }

    }
}
