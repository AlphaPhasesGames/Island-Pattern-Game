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

        public GameObject text1;
        public GameObject text2;
        public GameObject text3;
        public GameObject text4;
        public GameObject text5;
        public GameObject text6;
        public GameObject text7;
        public GameObject text8;
        public GameObject text9;
        public GameObject text10;
        public GameObject text11;
        public GameObject text12;

        public GameObject button1;
        public GameObject button2;
        public GameObject button3;
        public GameObject button4;
        public GameObject button5;
        public GameObject button6;
        public GameObject button7;
        public GameObject button8;
        public GameObject button9;
        public GameObject button10;
        public GameObject button11;
        public GameObject button12;

        public bool hasViewedPedastal;

        public GameObject slot1Circle1Correct;
        public GameObject slot1Triangle1;
        public GameObject slot1Hex1;
        public GameObject slot1Triangle2;
        public GameObject slot1Square1;
        public GameObject slot1Hex2;
        public GameObject slot1Circle2;
        public GameObject slot1Hex3;
        public GameObject slot1Square2;
        public GameObject slot1Circle3;
        public GameObject slot1Square3;
        public GameObject slot1Triangle3;

        public GameObject slot2Circle1;
        public GameObject slot2Triangle1Correct;
        public GameObject slot2Hex1;
        public GameObject slot2Triangle2;
        public GameObject slot2Square1;
        public GameObject slot2Hex2;
        public GameObject slot2Circle2;
        public GameObject slot2Hex3;
        public GameObject slot2Square2;
        public GameObject slot2Circle3;
        public GameObject slot2Square3;
        public GameObject slot2Triangle3;

        public GameObject slot3Circle1;
        public GameObject slot3Triangle1;
        public GameObject slot3Hex1Correct;
        public GameObject slot3Triangle2;
        public GameObject slot3Square1;
        public GameObject slot3Hex2;
        public GameObject slot3Circle2;
        public GameObject slot3Hex3;
        public GameObject slot3Square2;
        public GameObject slot3Circle3;
        public GameObject slot3Square3;
        public GameObject slot3Triangle3;

        public GameObject slot4Circle1;
        public GameObject slot4Triangle1;
        public GameObject slot4Hex1;
        public GameObject slot4Triangle2Correct;
        public GameObject slot4Square1;
        public GameObject slot4Hex2;
        public GameObject slot4Circle2;
        public GameObject slot4Hex3;
        public GameObject slot4Square2;
        public GameObject slot4Circle3;
        public GameObject slot4Square3;
        public GameObject slot4Triangle3;

        public GameObject slot5Circle1;
        public GameObject slot5Triangle1;
        public GameObject slot5Hex1;
        public GameObject slot5Triangle2;
        public GameObject slot5Square1Correct;
        public GameObject slot5Hex2;
        public GameObject slot5Circle2;
        public GameObject slot5Hex3;
        public GameObject slot5Square2;
        public GameObject slot5Circle3;
        public GameObject slot5Square3;
        public GameObject slot5Triangle3;

        public GameObject slot6Circle1;
        public GameObject slot6Triangle1;
        public GameObject slot6Hex1;
        public GameObject slot6Triangle2;
        public GameObject slot6Square1;
        public GameObject slot6Hex2Correct;
        public GameObject slot6Circle2;
        public GameObject slot6Hex3;
        public GameObject slot6Square2;
        public GameObject slot6Circle3;
        public GameObject slot6Square3;
        public GameObject slot6Triangle3;

        public GameObject slot7Circle1;
        public GameObject slot7Triangle1;
        public GameObject slot7Hex1;
        public GameObject slot7Triangle2;
        public GameObject slot7Square1;
        public GameObject slot7Hex2;
        public GameObject slot7Circle2Correct;
        public GameObject slot7Hex3;
        public GameObject slot7Square2;
        public GameObject slot7Circle3;
        public GameObject slot7Square3;
        public GameObject slot7Triangle3;

        public GameObject slot8Circle1;
        public GameObject slot8Triangle1;
        public GameObject slot8Hex1;
        public GameObject slot8Triangle2;
        public GameObject slot8Square1;
        public GameObject slot8Hex2;
        public GameObject slot8Circle2;
        public GameObject slot8Hex3Correct;
        public GameObject slot8Square2;
        public GameObject slot8Circle3;
        public GameObject slot8Square3;
        public GameObject slot8Triangle3;

        public GameObject slot9Circle1;
        public GameObject slot9Triangle1;
        public GameObject slot9Hex1;
        public GameObject slot9Triangle2;
        public GameObject slot9Square1;
        public GameObject slot9Hex2;
        public GameObject slot9Circle2;
        public GameObject slot9Hex3;
        public GameObject slot9Square2Correct;
        public GameObject slot9Circle3;
        public GameObject slot9Square3;
        public GameObject slot9Triangle3;

        public GameObject slot10Circle1;
        public GameObject slot10Triangle1;
        public GameObject slot10Hex1;
        public GameObject slot10Triangle2;
        public GameObject slot10Square1;
        public GameObject slot10Hex2;
        public GameObject slot10Circle2;
        public GameObject slot10Hex3;
        public GameObject slot10Square2;
        public GameObject slot10Circle3Correct;
        public GameObject slot10Square3;
        public GameObject slot10Triangle3;

        public GameObject slot11Circle1;
        public GameObject slot11Triangle1;
        public GameObject slot11Hex1;
        public GameObject slot11Triangle2;
        public GameObject slot11Square1;
        public GameObject slot11Hex2;
        public GameObject slot11Circle2;
        public GameObject slot11Hex3;
        public GameObject slot11Square2;
        public GameObject slot11Circle3;
        public GameObject slot11Square3Correct;
        public GameObject slot11Triangle3;

        public GameObject slot12Circle1;
        public GameObject slot12Triangle1;
        public GameObject slot12Hex1;
        public GameObject slot12Triangle2;
        public GameObject slot12Square1;
        public GameObject slot12Hex2;
        public GameObject slot12Circle2;
        public GameObject slot12Hex3;
        public GameObject slot12Square2;
        public GameObject slot12Circle3;
        public GameObject slot12Square3;
        public GameObject slot12Triangle3Correct;

        public GameObject slot1Circle1Image;
        public GameObject slot1Triangle1Image;
        public GameObject slot1Hex1Image;
        public GameObject slot1Triangle2Image;
        public GameObject slot1Square1Image;
        public GameObject slot1Hex2Image;
        public GameObject slot1Circle2Image2;
        public GameObject slot1Hex3Image;
        public GameObject slot1Square2Image;
        public GameObject slot1Circle3mage;
        public GameObject slot1Square3Image;
        public GameObject slot1Triangle3Image;

        public Stage2Scene2Circle1InvItem circle1Prop;
        public Stage2Scene2Circle2InvItem circle2Prop;
        public StageScene2Circle3InvItem circle3Prop;

        public Stage2Scene2SquareInventoryItem squareProp;
        public StageScene2Square2InvItem square2Prop;
        public StageScene2Square3InvItem square3Prop;

        public Stage2Scene2Triangle1InventoryItem tri1Prop;
        public Stage2Scene2TriangleInventoryItem tri2Prop;
        public Stage2Scene2Triangle3InvItem tri3Prop;

        public Stage2Scene2Hexagon1InvItem hex1Prop;
        public Stage2Scene2Hexagon2InvItem hex2Prop;
        public Stage2Scene2Hexagon3InvItem hex3Prop;

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


            slot1Circle1Correct.gameObject.SetActive(false);
            slot1Triangle1.gameObject.SetActive(false);
            slot1Hex1.gameObject.SetActive(false);
            slot1Triangle2.gameObject.SetActive(false);
            slot1Square1.gameObject.SetActive(false);
            slot1Hex2.gameObject.SetActive(false);
            slot1Circle2.gameObject.SetActive(false);
            slot1Hex3.gameObject.SetActive(false);
            slot1Square2.gameObject.SetActive(false);
            slot1Circle3.gameObject.SetActive(false);
            slot1Square3.gameObject.SetActive(false);
            slot1Triangle3.gameObject.SetActive(false);

            slot2Circle1.gameObject.SetActive(false);
            slot2Triangle1Correct.gameObject.SetActive(false);
            slot2Hex1.gameObject.SetActive(false);
            slot2Triangle2.gameObject.SetActive(false);
            slot2Square1.gameObject.SetActive(false);
            slot2Hex2.gameObject.SetActive(false);
            slot2Circle2.gameObject.SetActive(false);
            slot2Hex3.gameObject.SetActive(false);
            slot2Square2.gameObject.SetActive(false);
            slot2Circle3.gameObject.SetActive(false);
            slot2Square3.gameObject.SetActive(false);
            slot2Triangle3.gameObject.SetActive(false);

            slot3Circle1.gameObject.SetActive(false);
            slot3Triangle1.gameObject.SetActive(false);
            slot3Hex1Correct.gameObject.SetActive(false);
            slot3Triangle2.gameObject.SetActive(false);
            slot3Square1.gameObject.SetActive(false);
            slot3Hex2.gameObject.SetActive(false);
            slot3Circle2.gameObject.SetActive(false);
            slot3Hex3.gameObject.SetActive(false);
            slot3Square2.gameObject.SetActive(false);
            slot3Circle3.gameObject.SetActive(false);
            slot3Square3.gameObject.SetActive(false);
            slot3Triangle3.gameObject.SetActive(false);

            slot4Circle1.gameObject.SetActive(false);
            slot4Triangle1.gameObject.SetActive(false);
            slot4Hex1.gameObject.SetActive(false);
            slot4Triangle2Correct.gameObject.SetActive(false);
            slot4Square1.gameObject.SetActive(false);
            slot4Hex2.gameObject.SetActive(false);
            slot4Circle2.gameObject.SetActive(false);
            slot4Hex3.gameObject.SetActive(false);
            slot4Square2.gameObject.SetActive(false);
            slot4Circle3.gameObject.SetActive(false);
            slot4Square3.gameObject.SetActive(false);
            slot4Triangle3.gameObject.SetActive(false);

            slot5Circle1.gameObject.SetActive(false);
            slot5Triangle1.gameObject.SetActive(false);
            slot5Hex1.gameObject.SetActive(false);
            slot5Triangle2.gameObject.SetActive(false);
            slot5Square1Correct.gameObject.SetActive(false);
            slot5Hex2.gameObject.SetActive(false);
            slot5Circle2.gameObject.SetActive(false);
            slot5Hex3.gameObject.SetActive(false);
            slot5Square2.gameObject.SetActive(false);
            slot5Circle3.gameObject.SetActive(false);
            slot5Square3.gameObject.SetActive(false);
            slot5Triangle3.gameObject.SetActive(false);

            slot6Circle1.gameObject.SetActive(false);
            slot6Triangle1.gameObject.SetActive(false);
            slot6Hex1.gameObject.SetActive(false);
            slot6Triangle2.gameObject.SetActive(false);
            slot6Square1.gameObject.SetActive(false);
            slot6Hex2Correct.gameObject.SetActive(false);
            slot6Circle2.gameObject.SetActive(false);
            slot6Hex3.gameObject.SetActive(false);
            slot6Square2.gameObject.SetActive(false);
            slot6Circle3.gameObject.SetActive(false);
            slot6Square3.gameObject.SetActive(false);
            slot6Triangle3.gameObject.SetActive(false);

            slot7Circle1.gameObject.SetActive(false);
            slot7Triangle1.gameObject.SetActive(false);
            slot7Hex1.gameObject.SetActive(false);
            slot7Triangle2.gameObject.SetActive(false);
            slot7Square1.gameObject.SetActive(false);
            slot7Hex2.gameObject.SetActive(false);
            slot7Circle2Correct.gameObject.SetActive(false);
            slot7Hex3.gameObject.SetActive(false);
            slot7Square2.gameObject.SetActive(false);
            slot7Circle3.gameObject.SetActive(false);
            slot7Square3.gameObject.SetActive(false);
            slot7Triangle3.gameObject.SetActive(false);

            slot8Circle1.gameObject.SetActive(false);
            slot8Triangle1.gameObject.SetActive(false);
            slot8Hex1.gameObject.SetActive(false);
            slot8Triangle2.gameObject.SetActive(false);
            slot8Square1.gameObject.SetActive(false);
            slot8Hex2.gameObject.SetActive(false);
            slot8Circle2.gameObject.SetActive(false);
            slot8Hex3Correct.gameObject.SetActive(false);
            slot8Square2.gameObject.SetActive(false);
            slot8Circle3.gameObject.SetActive(false);
            slot8Square3.gameObject.SetActive(false);
            slot8Triangle3.gameObject.SetActive(false);


            slot9Circle1.gameObject.SetActive(false);
            slot9Triangle1.gameObject.SetActive(false);
            slot9Hex1.gameObject.SetActive(false);
            slot9Triangle2.gameObject.SetActive(false);
            slot9Square1.gameObject.SetActive(false);
            slot9Hex2.gameObject.SetActive(false);
            slot9Circle2.gameObject.SetActive(false);
            slot9Hex3.gameObject.SetActive(false);
            slot9Square2Correct.gameObject.SetActive(false);
            slot9Circle3.gameObject.SetActive(false);
            slot9Square3.gameObject.SetActive(false);
            slot9Triangle3.gameObject.SetActive(false);

            slot10Circle1.gameObject.SetActive(false);
            slot10Triangle1.gameObject.SetActive(false);
            slot10Hex1.gameObject.SetActive(false);
            slot10Triangle2.gameObject.SetActive(false);
            slot10Square1.gameObject.SetActive(false);
            slot10Hex2.gameObject.SetActive(false);
            slot10Circle2.gameObject.SetActive(false);
            slot10Hex3.gameObject.SetActive(false);
            slot10Square2.gameObject.SetActive(false);
            slot10Circle3Correct.gameObject.SetActive(false);
            slot10Square3.gameObject.SetActive(false);
            slot10Triangle3.gameObject.SetActive(false);

            slot11Circle1.gameObject.SetActive(false);
            slot11Triangle1.gameObject.SetActive(false);
            slot11Hex1.gameObject.SetActive(false);
            slot11Triangle2.gameObject.SetActive(false);
            slot11Square1.gameObject.SetActive(false);
            slot11Hex2.gameObject.SetActive(false);
            slot11Circle2.gameObject.SetActive(false);
            slot11Hex3.gameObject.SetActive(false);
            slot11Square2.gameObject.SetActive(false);
            slot11Circle3.gameObject.SetActive(false);
            slot11Square3Correct.gameObject.SetActive(false);
            slot11Triangle3.gameObject.SetActive(false);

            slot12Circle1.gameObject.SetActive(false);
            slot12Triangle1.gameObject.SetActive(false);
            slot12Hex1.gameObject.SetActive(false);
            slot12Triangle2.gameObject.SetActive(false);
            slot12Square1.gameObject.SetActive(false);
            slot12Hex2.gameObject.SetActive(false);
            slot12Circle2.gameObject.SetActive(false);
            slot12Hex3.gameObject.SetActive(false);
            slot12Square2.gameObject.SetActive(false);
            slot12Circle3.gameObject.SetActive(false);
            slot12Square3.gameObject.SetActive(false);
            slot12Triangle3Correct.gameObject.SetActive(false);
           
            squareProp.DeSelectSphereItemPedestal();
            square2Prop.DeSelectSphereItemPedestal();
            square3Prop.DeSelectSphereItemPedestal();
            tri1Prop.DeSelectSphereItemPedestel();
            tri2Prop.DeSelectSphereItemPedestel();
            tri3Prop.DeSelectSphereItemPedestel();
            circle1Prop.DeSelectSphereItemPedestal();
            circle2Prop.DeSelectSphereItemPedestal();
            circle3Prop.DeSelectSphereItemPedestal();
            tri1Prop.DeSelectSphereItemPedestel();
            tri2Prop.DeSelectSphereItemPedestel();
            tri3Prop.DeSelectSphereItemPedestel();

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

            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            button3.gameObject.SetActive(true);
            button4.gameObject.SetActive(true);
            button5.gameObject.SetActive(true);
            button6.gameObject.SetActive(true);
            button7.gameObject.SetActive(true);
            button8.gameObject.SetActive(true);
            button9.gameObject.SetActive(true);
            button10.gameObject.SetActive(true);
            button11.gameObject.SetActive(true);
            button12.gameObject.SetActive(true);

            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(false);
            text5.gameObject.SetActive(false);
            text6.gameObject.SetActive(false);
            text7.gameObject.SetActive(false);
            text8.gameObject.SetActive(false);
            text9.gameObject.SetActive(false);
            text10.gameObject.SetActive(false);
            text11.gameObject.SetActive(false);
            text12.gameObject.SetActive(false);

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFIlled = false;
            slot4.slotFIlled = false;
            slot5.slotFIlled = false;
            slot6.slotFilled = false;
            slot7.slotFilled = false;
            slot8.slotFilled = false;
            slot9.slotFilled = false;
            slot10.slotFilled = false;
            slot11.slotFilled = false;
            slot12.slotFilled = false;

            progScript.runTwice = false;
            textMan.ResetPositionFlags();
            
        }
    }

}