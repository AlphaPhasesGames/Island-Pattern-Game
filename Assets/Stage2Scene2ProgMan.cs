using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2ProgMan : MonoBehaviour
    {
     //   public Stage2Scene2ShapePlacementSlot1 slot1;
        public Stage2Scene2ShapePlacementSlot2 slot2;
        public Stage2Scene2ShapePlacementSlot4 slot4;
        //public Stage2Scene2ShapePlacementSlot3 slot3;
        public Stage2Scene2ShapePlacementSlot5 slot5;
        public Stage2Scene2ShapePlacementSlot6 slot6;
        public Stage2Scene2ShapePlacementSlot7 slot7;
      //  public Stage2Scene2ShapePlacementSlot8 slot8;
        public Stage2Scene2ShapePlacementSlot9 slot9;
      //  public Stage2Scene2ShapePlacementSlot10 slot10;
        public Stage2Scene2ShapePlacementSlot11 slot11;
      //  public Stage2Scene2ShapePlacementSlot12 slot12;
        public stage2scene2shapeplacement13 slot13;
        public Stage2Scene2ShapePlacement14 slot14;
      //  public Stage2Scene2ShapePlacement15 slot15;
        public Stage2Scene2ShapePlacement16 slot16;
        public Stage2Scene2ShapePlacement17 slot17;
        public Stage2Scene2ShapePlacement18 slot18;
        public Stage2Scene2ShapePlacement19 slot19;
      //  public Stage2Scene2ShapePlacement20 slot20;
        public Stage2Scene2TextMan textMan;
        public GameObject exitTrigger;
        public bool runOnce;
        public bool runTwice;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot2.correctPlacement && slot4.correctPlacement && slot5.correctPlacement && slot6.correctPlacement && slot7.correctPlacement &&  slot9.correctPlacement && slot11.correctPlacement  && slot13.correctPlacement && slot14.correctPlacement && slot16.correctPlacement && slot17.correctPlacement && slot18.correctPlacement && slot19.correctPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 15;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot2.inCorrectPlacement || slot4.inCorrectPlacement || slot5.inCorrectPlacement || slot6.inCorrectPlacement || slot7.inCorrectPlacement || slot9.inCorrectPlacement || slot11.inCorrectPlacement || slot13.inCorrectPlacement || slot14.inCorrectPlacement ||  slot16.inCorrectPlacement || slot17.inCorrectPlacement || slot18.inCorrectPlacement || slot19.inCorrectPlacement)
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
