using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class RespawnCharacterWater : MonoBehaviour
    {
        public GameObject respawnPoint;
        public GameObject robotPlayer;
        public CharacterController charCont;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                MovePlayer();
            }

        }

        public void MovePlayer()
        {
            charCont.enabled = false;
            robotPlayer.transform.rotation = respawnPoint.transform.rotation;
            robotPlayer.transform.position = respawnPoint.transform.position;
            charCont.enabled = true;
        }
    }
}
