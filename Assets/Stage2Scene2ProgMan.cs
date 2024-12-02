using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2ProgMan : MonoBehaviour
    {
        public Stage2Scene2ShapePlacementSlot1 slot1;
        public Stage2Scene2ShapePlacementSlot2 slot2;
        public Stage2Scene2ShapePlacementSlot4 slot4;
        public Stage2Scene2ShapePlacementSlot3 slot3;
        public Stage2Scene2ShapePlacementSlot5 slot5;
        public Stage2Scene2ShapePlacementSlot6 slot6;
        public Stage2Scene2ShapePlacementSlot7 slot7;
        public Stage2Scene2ShapePlacementSlot8 slot8;
        public Stage2Scene2ShapePlacementSlot9 slot9;
        public Stage2Scene2ShapePlacementSlot10 slot10;
        public Stage2Scene2ShapePlacementSlot11 slot11;
        public Stage2Scene2ShapePlacementSlot12 slot12;
        public Stage2Scene2TextMan textMan;
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
                    textMan.arrayPos = 15;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot1.inCorrectPlacement || slot2.inCorrectPlacement || slot3.inCorrectPlacement || slot4.inCorrectPlacement || slot5.inCorrectPlacement || slot6.inCorrectPlacement || slot7.inCorrectPlacement || slot8.inCorrectPlacement || slot12.inCorrectPlacement || slot9.inCorrectPlacement || slot10.inCorrectPlacement || slot11.inCorrectPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 14;
                    //    exitTrigger.gameObject.SetActive(true);
                    runTwice = true;
                }
            }

        }
    }
}
