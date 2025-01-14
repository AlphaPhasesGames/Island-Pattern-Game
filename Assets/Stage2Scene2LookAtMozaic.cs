using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2LookAtMozaic : MonoBehaviour
    {
        // Reference to the Collider component of the object
       public Stage2Scene2TextMan textMan;
       public S2S2CollectionsManager collectMan;
        public Stage2Scene2ProgMan progScript;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;
        public GameObject invPanal;

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
        public stage2scene2shapeplacement13 slot13;
        public Stage2Scene2ShapePlacement14 slot14;
        public Stage2Scene2ShapePlacement15 slot15;
        public Stage2Scene2ShapePlacement16 slot16;
        public Stage2Scene2ShapePlacement17 slot17;
        public Stage2Scene2ShapePlacement18 slot18;
        public Stage2Scene2ShapePlacement19 slot19;
        public Stage2Scene2ShapePlacement20 slot20;

        public GameObject text1Square;
        public GameObject text2Diamond;
        public GameObject text3Pentagon;

        public GameObject button1Square;
        public GameObject button2Diamond;
        public GameObject button3Pentagon;


        public bool hasViewedPedastal;


        public GameObject slot1Hex1Correct;
        public GameObject slot1Square1;
        public GameObject slot1Diamond;

        public GameObject slot2Hex1;
        public GameObject slot2Square1;
        public GameObject slot2DiamondCorrect;

        public GameObject slot3Hex1;
        public GameObject slot3Square1;
        public GameObject slot3DiamondCorrect;

        public GameObject slot4Hex1Correct;
        public GameObject slot4Square1;
        public GameObject slot4Diamond;

        public GameObject slot5Hex1;
        public GameObject slot5Square1;
        public GameObject slot5DiamondCorrect;

        public GameObject slot6Hex1;
        public GameObject slot6Square1;
        public GameObject slot6DiamondCorrect;

        public GameObject slot7Hex1;
        public GameObject slot7Square1Correct;
        public GameObject slot7Diamond;

        public GameObject slot8Hex1;
        public GameObject slot8Square1Correct;
        public GameObject slot8Diamond;

        public GameObject slot9Hex1;
        public GameObject slot9Square1Correct;
        public GameObject slot9Diamond;

        public GameObject slot10Hex1Correct;
        public GameObject slot10Square1;
        public GameObject slot10Diamond;

        public GameObject slot11Hex1Correct;
        public GameObject slot11Square1;
        public GameObject slot11Diamond;

        public GameObject slot12Hex1;
        public GameObject slot12Square1;
        public GameObject slot12DiamondCorrect;

        public GameObject slot13Hex1;
        public GameObject slot13Square1;
        public GameObject slot13DiamondCorrect;

        public GameObject slot14Hex1;
        public GameObject slot14Square1Correct;
        public GameObject slot14Diamond;

        public GameObject slot15Hex1;
        public GameObject slot15Square1Correct;
        public GameObject slot15Diamond;

        public GameObject slot16Hex1;
        public GameObject slot16Square1Correct;
        public GameObject slot16Diamond;

        public GameObject slot17Hex1Correct;
        public GameObject slot17Square1;
        public GameObject slot17Diamond;

        public GameObject slot18Hex1Correct;
        public GameObject slot18Square1;
        public GameObject slot18Diamond;

        public GameObject slot19Hex1Correct;
        public GameObject slot19Square1;
        public GameObject slot19Diamond;

        public GameObject slot20Hex1Correct;
        public GameObject slot20Square1;
        public GameObject slot20Diamond;
  
      //  public GameObject slot1Hex1Image;
     //   public GameObject slot1Square1Image;
    //    public GameObject slot1Diamond1Image;

        public Stage2Scene2SquareInventoryItem squareProp;
        public Stage2Scene2Hexagon1InvItem hex1Prop;
        public Stage2Scene2DiamondInvItem diamondProp;

        public RobotController robCont;
        public GameObject robotToHide;

        private void Awake()
        {
            closeButton.onClick.AddListener(ClosePedastalVeiw);
            resetButton.onClick.AddListener(ResetSpeheres);
        }

        // Handle what happens when the trigger box is clicked
        private void OnTriggerBoxClicked()
        {

            if (!collectMan.allSpheresCollected)
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 10;
                hasViewedPedastal = true;
            }

            if (collectMan.allSpheresCollected)
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 16;
                hasViewedPedastal = true;
            }
            robCont.isCharActive = false;
            robotToHide.gameObject.SetActive(false);
            playerCamToDisable.enabled = false;
            pedastalCam.enabled = true;
            triggerCollider.enabled = false;
            closeButton.gameObject.SetActive(true);
            resetButton.gameObject.SetActive(true);
            Debug.Log("Trigger box clicked!");
            // Add your logic here (e.g., open a door, activate something, etc.)
        }

        public void ClosePedastalVeiw()
        {
            playerCamToDisable.enabled = true;
            pedastalCam.enabled = false;
            triggerCollider.enabled = true;
            resetButton.gameObject.SetActive(false);
            closeButton.gameObject.SetActive(false);
            invPanal.gameObject.SetActive(false);
            robCont.isCharActive = true;
            robotToHide.gameObject.SetActive(true);
        }


        void OnMouseDown()
        {
            OnTriggerBoxClicked();
        }
       
    
       

        public void ResetSpeheres()
        {



            slot1Square1.gameObject.SetActive(false);
            slot1Hex1Correct.gameObject.SetActive(false);
            slot1Diamond.gameObject.SetActive(false);

            slot2Square1.gameObject.SetActive(false);
            slot2Hex1.gameObject.SetActive(false);
            slot2DiamondCorrect.gameObject.SetActive(false);

            slot3Square1.gameObject.SetActive(false);
            slot3Hex1.gameObject.SetActive(false);
            slot3DiamondCorrect.gameObject.SetActive(false);

            slot4Square1.gameObject.SetActive(false);
            slot4Hex1Correct.gameObject.SetActive(false);
            slot4Diamond.gameObject.SetActive(false);

            slot5Square1.gameObject.SetActive(false);
            slot5Hex1.gameObject.SetActive(false);
            slot5DiamondCorrect.gameObject.SetActive(false);

            slot6Square1.gameObject.SetActive(false);
            slot6Hex1.gameObject.SetActive(false);
            slot6DiamondCorrect.gameObject.SetActive(false);

            slot7Square1Correct.gameObject.SetActive(false);
            slot7Hex1.gameObject.SetActive(false);
            slot7Diamond.gameObject.SetActive(false);

            slot8Square1Correct.gameObject.SetActive(false);
            slot8Hex1.gameObject.SetActive(false);
            slot8Diamond.gameObject.SetActive(false);

            slot9Square1Correct.gameObject.SetActive(false);
            slot9Hex1.gameObject.SetActive(false);
            slot9Diamond.gameObject.SetActive(false);

            slot10Square1.gameObject.SetActive(false);
            slot10Hex1Correct.gameObject.SetActive(false);
            slot10Diamond.gameObject.SetActive(false);

            slot11Square1.gameObject.SetActive(false);
            slot11Hex1Correct.gameObject.SetActive(false);
            slot11Diamond.gameObject.SetActive(false);

            slot12Square1.gameObject.SetActive(false);
            slot12Hex1.gameObject.SetActive(false);
            slot12DiamondCorrect.gameObject.SetActive(false);

            slot13Square1.gameObject.SetActive(false);
            slot13Hex1.gameObject.SetActive(false);
            slot13DiamondCorrect.gameObject.SetActive(false);

            slot14Square1Correct.gameObject.SetActive(false);
            slot14Hex1.gameObject.SetActive(false);
            slot14Diamond.gameObject.SetActive(false);

            slot15Square1Correct.gameObject.SetActive(false);
            slot15Hex1.gameObject.SetActive(false);
            slot15Diamond.gameObject.SetActive(false);

            slot16Square1Correct.gameObject.SetActive(false);
            slot16Hex1.gameObject.SetActive(false);
            slot16Diamond.gameObject.SetActive(false);

            slot17Square1.gameObject.SetActive(false);
            slot17Hex1Correct.gameObject.SetActive(false);
            slot17Diamond.gameObject.SetActive(false);

            slot18Square1.gameObject.SetActive(false);
            slot18Hex1Correct.gameObject.SetActive(false);
            slot18Diamond.gameObject.SetActive(false);

            slot19Square1.gameObject.SetActive(false);
            slot19Hex1Correct.gameObject.SetActive(false);
            slot19Diamond.gameObject.SetActive(false);

            slot20Square1.gameObject.SetActive(false);
            slot20Hex1Correct.gameObject.SetActive(false);
            slot20Diamond.gameObject.SetActive(false);

            squareProp.DeSelectSphereItemPedestal();
            hex1Prop.DeSelectSphereItemPedestal();
            diamondProp.DeSelectSphereItemPedestal();

            slot1.inCorrectPlacement = false;
            slot2.inCorrectPlacement = false;
            slot3.inCorrectPlacement = false;
            slot4.inCorrectPlacement = false;
            slot5.inCorrectPlacement = false;
            slot6.inCorrectPlacement = false;
            slot7.inCorrectPlacement = false;
            slot8.inCorrectPlacement = false;
            slot9.inCorrectPlacement = false;
            slot10.inCorrectPlacement = false;
            slot11.inCorrectPlacement = false;
            slot12.inCorrectPlacement = false;
            slot13.inCorrectPlacement = false;
            slot14.inCorrectPlacement = false;
            slot15.inCorrectPlacement = false;
            slot16.inCorrectPlacement = false;
            slot17.inCorrectPlacement = false;
            slot18.inCorrectPlacement = false;
            slot19.inCorrectPlacement = false;
            slot20.inCorrectPlacement = false;


            slot1.correctPlacement = false;
            slot2.correctPlacement = false;
            slot3.correctPlacement = false;
            slot4.correctPlacement = false;
            slot5.correctPlacement = false;
            slot6.correctPlacement = false;
            slot7.correctPlacement = false;
            slot8.correctPlacement = false;
            slot9.correctPlacement = false;
            slot10.correctPlacement = false;
            slot11.correctPlacement = false;
            slot12.correctPlacement = false;
            slot13.correctPlacement = false;
            slot14.correctPlacement = false;
            slot15.correctPlacement = false;
            slot16.correctPlacement = false;
            slot17.correctPlacement = false;
            slot18.correctPlacement = false;
            slot19.correctPlacement = false;
            slot20.correctPlacement = false;


            button1Square.gameObject.SetActive(true);
            button2Diamond.gameObject.SetActive(true);
            button3Pentagon.gameObject.SetActive(true);

            text1Square.gameObject.SetActive(false);
            text2Diamond.gameObject.SetActive(false);
            text3Pentagon.gameObject.SetActive(false);

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFilled = false;
            slot4.slotFilled = false;
            slot5.slotFilled = false;
            slot6.slotFilled = false;
            slot7.slotFilled = false;
            slot8.slotFilled = false;
            slot9.slotFilled = false;
            slot10.slotFilled = false;
            slot11.slotFilled = false;
            slot12.slotFilled = false;
            slot13.slotFilled = false;
            slot14.slotFilled = false;
            slot15.slotFilled = false;
            slot16.slotFilled = false;
            slot17.slotFilled = false;
            slot18.slotFilled = false;
            slot19.slotFilled = false;
            slot20.slotFilled = false;


            progScript.runTwice = false;
            textMan.ResetPositionFlags();
            
        }
    }

}