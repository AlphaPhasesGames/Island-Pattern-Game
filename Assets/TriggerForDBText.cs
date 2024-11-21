using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class TriggerForDBText : MonoBehaviour
    {
        public Stage2Scene1TextMan textMan;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 3;
               // Debug.Log("Firing array 3");
                Destroy(this.gameObject);
            }
        }
    }
}
