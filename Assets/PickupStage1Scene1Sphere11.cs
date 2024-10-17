using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere11 : MonoBehaviour
    {
        public GameObject sphere11;
        public Button sphereButton;
        private void OnTriggerEnter(Collider other)
        {
            sphereButton.gameObject.SetActive(true);
            sphere11.gameObject.SetActive(false);

        }
    }
}
