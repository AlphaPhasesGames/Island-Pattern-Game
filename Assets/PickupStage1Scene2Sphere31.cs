using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene2Sphere31 : MonoBehaviour
    {
        public Stage1Scene2CollectablesManager collectMan;
        public GameObject sphere31;
        public Button sphere31Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphere31Button.gameObject.SetActive(true);
            sphere31.gameObject.SetActive(false);
        }
    }
}
