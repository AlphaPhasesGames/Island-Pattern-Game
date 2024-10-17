using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PickupStage1Scene1Sphere10 : MonoBehaviour
    {
        public GameObject sphere10;
        public Button sphereButton;
        private void OnTriggerEnter(Collider other)
        {
            sphereButton.gameObject.SetActive(true);
            sphere10.gameObject.SetActive(false);

        }
    }
}
