using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3ProgressionManager : MonoBehaviour
    {
        public Stage3NumberPlacementSlot1 slot1;
        public Stage3NumberPlacementSlot2 slot2;
        public Stage3NumberPlacementSlot3 slot3;
        public Stage3NumberPlacementSlot4 slot4;
        public Stage3NumberPlacementSlot5 slot5;
        public Stage3NumberPlacementSlot6 slot6;
        public Stage3NumberPlacementSlot7 slot7;
        public Stage3NumberPlacementSlot8 slot8;
        public Stage3NumberPlacementSlot9 slot9;
        public Stage3NumberPlacementSlot10 slot10;
        public Stage3NumberPlacementSlot11 slot11;
        public Stage3NumberPlacementSlot12 slot12;
        public Stage3TextMan textMan;
        public GameObject exitTrigger;
        public bool runOnce;
        public bool runTwice;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot1.correctPlacement && slot2.correctPlacement && slot3.correctPlacement && slot4.correctPlacement && slot5.correctPlacement && slot6.correctPlacement && slot7.correctPlacement && slot8.correctPlacement && slot9.correctPlacement && slot10.correctPlacement && slot11.correctPlacement && slot12.correctPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 22;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot1.inCorrectPlacement || slot2.inCorrectPlacement || slot3.inCorrectPlacement || slot4.inCorrectPlacement || slot5.inCorrectPlacement || slot6.inCorrectPlacement || slot7.inCorrectPlacement || slot8.inCorrectPlacement || slot9.inCorrectPlacement || slot10.inCorrectPlacement || slot11.inCorrectPlacement || slot12.inCorrectPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 21;
                    //exitTrigger.gameObject.SetActive(true);
                    runTwice = true;
                }
            }

        }
    }
}