using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2ProgressScript : MonoBehaviour
    {
        public Stage1Scene2SpherePlacementSlot1 slot1;
        public Stage1Scene2SPherePlacementSlot2 slot2;
        public Stage1Scene2SpherePlacementSlot3 slot3;
        public Stage1Scene2TextMan textMan;
        public GameObject exitTrigger;
        public bool runOnce;
        public bool runTwice;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot1.correctPlacement && slot2.correctPlacement && slot3.correctPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 9;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot1.inCorrectPlacement || slot2.inCorrectPlacement || slot3.inCorrectPlacement)
                {

                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 10;
                //    exitTrigger.gameObject.SetActive(true);
                    runTwice = true;
                }
            }


        }
      
    }
}
