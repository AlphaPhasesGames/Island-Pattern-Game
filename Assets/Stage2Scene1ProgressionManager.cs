using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1ProgressionManager : MonoBehaviour
    {
        public Stage2Scene1ShapePlacementSlot1 slot1;
        public Stage2Scene1ShapePlacementSlot2 slot2;
        public Stage2Scene1ShapePlacementSlot4 slot4;
        public Stage2Scene1ShapePlacementSlot3 slot3;
        public Stage2Scene1ShapePlacement5 slot5;
        public Stage2Scene1ShapePlacement6 slot6;
        public Stage2Scene1ShapePlacement7 slot7;
        public Stage2Scene1ShapePlacement8 slot8;
        public Stage2Scene1TextMan textMan;
        public GameObject exitTrigger;
        public bool runOnce;
        public bool runTwice;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot1.correctPlacement && slot2.correctPlacement && slot3.correctPlacement && slot4.correctPlacement && slot5.correctPlacement && slot6.correctPlacement && slot7.correctPlacement && slot8.correctPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 12;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot1.inCorrectPlacement || slot2.inCorrectPlacement || slot3.inCorrectPlacement || slot4.inCorrectPlacement || slot5.inCorrectPlacement || slot6.inCorrectPlacement || slot7.inCorrectPlacement || slot8.inCorrectPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 11;
                    //    exitTrigger.gameObject.SetActive(true);
                    runTwice = true;
                }
            }

        }
    }
}
