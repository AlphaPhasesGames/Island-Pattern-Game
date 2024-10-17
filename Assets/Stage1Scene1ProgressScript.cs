
using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1ProgressScript : MonoBehaviour
    {
        public Stage1Scene1SpherePlacementSlot1 slot1;
        public Stage1Scene1SpherePlacementSlot2 slot2;
        public Stage1Scene1SpherePlacementSlot3 slot3;

        public GameObject exitTrigger;
        public bool runOnce;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot1.correctPlacement && slot2.correctPlacement && slot3.correctPlacement)
                {
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

        }
    }
}
