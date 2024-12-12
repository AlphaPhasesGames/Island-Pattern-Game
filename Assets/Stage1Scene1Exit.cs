using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1Exit : MonoBehaviour
    {
        public bool submitOnce;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!submitOnce)
                {
                    LOLSDK.Instance.SubmitProgress(0, 20, 100);
                    submitOnce = true;
                }
                SceneManager.LoadScene("Stage 1 Scene 2");
            }
        }
    }
}
