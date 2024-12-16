using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene1Square : MonoBehaviour
    {
        public Stage2Scene1Collectables collectMan;
        public GameObject square;
        public Button squareButton;
        public AudioSource pickupSFX;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickupSFX.Play();
                collectMan.collectableCount++;
                squareButton.gameObject.SetActive(true);
                square.gameObject.SetActive(false);
            }
           

        }
    }
}
