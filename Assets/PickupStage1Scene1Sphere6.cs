using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere6 : MonoBehaviour
    {
        public GameObject sphere6;
        public Button sphereButton;
        private void OnTriggerEnter(Collider other)
        {
            sphereButton.gameObject.SetActive(true);
            sphere6.gameObject.SetActive(false);

        }
    }
}
