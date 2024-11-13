using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene2Sphere8 : MonoBehaviour
    {
        public Stage1Scene2CollectablesManager collectMan;
        public GameObject sphere8;
        public Button sphere8Button;
        public AudioSource pickupSFX;
        private void OnTriggerEnter(Collider other)
        {
            pickupSFX.Play();
            collectMan.collectableCount++;
            sphere8Button.gameObject.SetActive(true);
            sphere8.gameObject.SetActive(false);

        }
    }
}
