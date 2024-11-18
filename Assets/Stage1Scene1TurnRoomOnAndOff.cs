using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1TurnRoomOnAndOff : MonoBehaviour
    {
        public GameObject room;
        public bool roomEnabled;
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!roomEnabled)
                {
                    room.gameObject.SetActive(true);
                    roomEnabled = true;
                    Debug.Log("Room Enabled");
                }
              
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (roomEnabled)
                {
                    room.gameObject.SetActive(false);
                    roomEnabled = false;
                    Debug.Log("Room disabled");
                }
            }
        }
    }
}
