using UnityEngine;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1Exit : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene("Stage 2 Scene 1");
            }
        }
    }
}
