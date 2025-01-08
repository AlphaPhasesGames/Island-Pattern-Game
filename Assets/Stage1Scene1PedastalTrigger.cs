using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1PedastalTrigger : MonoBehaviour
    {
        public Stage1Scene1TextMan textMan;
        public Stage1Scene1StartScript startScript;
        public bool runOnce;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!runOnce)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 9;
                    startScript.SaveGame();
                    Destroy(this.gameObject);
                    runOnce = true;
                }

            }
        }
    }
}
