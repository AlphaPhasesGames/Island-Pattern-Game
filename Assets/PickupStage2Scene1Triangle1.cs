using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage2Scene1Triangle1 : MonoBehaviour
    {
        public Stage2Scene1Collectables collectMan;
        public GameObject triangle1;
        public Button triangleButton;
        public AudioSource pickupSFX;
        public bool runOnce;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!runOnce)
                {
                    pickupSFX.Play();
                    collectMan.collectableCount++;
                    triangleButton.gameObject.SetActive(true);
                    triangle1.gameObject.SetActive(false);
                    runOnce = true;
                }
             
            }

            if (other.CompareTag("Club"))
            {
                if (!runOnce)
                {
                    pickupSFX.Play();
                    collectMan.collectableCount++;
                    triangleButton.gameObject.SetActive(true);
                    triangle1.gameObject.SetActive(false);
                    runOnce = true;
                }

            }
        }
    }
}
