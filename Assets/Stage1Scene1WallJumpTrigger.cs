using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1WallJumpTrigger : MonoBehaviour
    {
        public Stage1Scene1TextMan textMan;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.arrayPos = 2;
                textMan.positionChanged = true; // Directly set positionChanged
                Destroy(this.gameObject);
            }
        }
    }
}
