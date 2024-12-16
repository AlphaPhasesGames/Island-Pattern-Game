using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1Exit : MonoBehaviour
    {
        public bool submitOnce;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!submitOnce)
                {
                    LOLSDK.Instance.SubmitProgress(0, 60, 100);
                    submitOnce = true;
                }
                SceneManager.LoadScene("Stage 2 Scene 2");
            }
        }
    }
}
