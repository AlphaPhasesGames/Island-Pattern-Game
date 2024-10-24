using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1ParrotTrigger : MonoBehaviour
    {
        public Stage1Scene1TextMan textMan;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.arrayPos = 3;
                Destroy(this.gameObject);
            }
        }
    }
}
