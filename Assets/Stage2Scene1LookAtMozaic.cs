using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage2Scene1LookAtMozaic : MonoBehaviour
    {

        // Reference to the Collider component of the object
        public Stage2Scene1TextMan textMan;
        public Stage2Scene1Collectables collectMan;
        public Stage2Scene1ProgressionManager progScript;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;

        public Stage2Scene1ShapePlacementSlot1 slot1;
        public Stage2Scene1ShapePlacementSlot2 slot2;
        public Stage2Scene1ShapePlacementSlot4 slot4;
        public Stage2Scene1ShapePlacementSlot3 slot3;
        public Stage2Scene1ShapePlacement5 slot5;
        public Stage2Scene1ShapePlacement6 slot6;
        public Stage2Scene1ShapePlacement7 slot7;
        public Stage2Scene1ShapePlacement8 slot8;

        public bool hasViewedPedastal;

        public GameObject sphere1Text;
        public GameObject sphere2Text;
        /*public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;
        */

        public GameObject slot1BlueTriangleCorrect;
        public GameObject slot1GreenTriangleIncorrect;

        public GameObject slot2BlueTriangleInCorrect;
        public GameObject slot2GreenTriangleCorrect;

        public GameObject slot3BlueTriangleCorrect;
        public GameObject slot3GreenTriangleIncorrect;

        public GameObject slot4BlueTriangleInCorrect;
        public GameObject slot4GreenTriangleCorrect;

        public GameObject slot5BlueTriangleCorrect;
        public GameObject slot5GreenTriangleIncorrect;

        public GameObject slot6BlueTriangleCorrect;
        public GameObject slot6GreenTriangleIncorrect;

        public GameObject slot7BlueTriangleCorrect;
        public GameObject slot7GreenTriangleIncorrect;

        public GameObject slot8BlueTriangleCorrect;
        public GameObject slot8GreenTriangleIncorrect;

        /*
        public GameObject slot2Circle;
        public GameObject slot2Circle2Correct;
        public GameObject slot2Triangle;
        public GameObject slot2Square;
        public GameObject slot2Triangle2;
        public GameObject slot2Triangle3;

        public GameObject slot3Circle;
        public GameObject slot3Circle2;
        public GameObject slot3TriangleCorrect;
        public GameObject slot3Square;
        public GameObject slot3Triangle2;
        public GameObject slot3Triangle3;

        public GameObject slot4Circle;
        public GameObject slot4Circle2;
        public GameObject slot4Triangle;
        public GameObject slot4SquareCorrect;
        public GameObject slot4Triangle2;
        public GameObject slot4Triangle3;

        public GameObject slot5Circle;
        public GameObject slot5Circle2;
        public GameObject slot5Triangle;
        public GameObject slot5Square;
        public GameObject slot5Triangle2Correct;
        public GameObject slot5Triangle3;

        public GameObject slot6Circle;
        public GameObject slot6Circle2;
        public GameObject slot6Triangle;
        public GameObject slot6Square;
        public GameObject slot6Triangle2;
        public GameObject slot6Triangle3Correct;
        */


        public Button blueTriangleButton;
        public Button greenTriangleButton;
        

      //  public GameObject slot1BlueTriangleImage;
     //   public GameObject slot1GreenTriangle2Image;


        public Stage2Scene1Triangle1InventoryItem tri1Prop;
        public Stage2Scene1Triangle2 tri2Prop;

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
           
            if (collectMan.allSpheresCollected)
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 10;
                hasViewedPedastal = true;
                playerCamToDisable.enabled = false;
                pedastalCam.enabled = true;
                triggerCollider.enabled = false;
                closeButton.gameObject.SetActive(true);
                resetButton.gameObject.SetActive(true);
            }
            else
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 2;
                playerCamToDisable.enabled = false;
                triggerCollider.enabled = false;
                pedastalCam.enabled = true;
                closeButton.gameObject.SetActive(true);
            }

            robCont.isCharActive = false;
            robotToHide.gameObject.SetActive(false);
            Debug.Log("Trigger box clicked!");
            // Add your logic here (e.g., open a door, activate something, etc.)
        }

        public void ClosePedastalVeiw()
        {
            robCont.isCharActive = true;
            robotToHide.gameObject.SetActive(true);
            playerCamToDisable.enabled = true;
            pedastalCam.enabled = false;
            triggerCollider.enabled = true;
            resetButton.gameObject.SetActive(false);
            closeButton.gameObject.SetActive(false);
        }


        void OnMouseDown()
        {
            OnTriggerBoxClicked();
        }

        public void ResetSpeheres()
        {


           
            slot1BlueTriangleCorrect.gameObject.SetActive(false);
            slot1GreenTriangleIncorrect.gameObject.SetActive(false);

            slot2BlueTriangleInCorrect.gameObject.SetActive(false);
            slot2GreenTriangleCorrect.gameObject.SetActive(false);

            slot3BlueTriangleCorrect.gameObject.SetActive(false);
            slot3GreenTriangleIncorrect.gameObject.SetActive(false);

            slot4BlueTriangleInCorrect.gameObject.SetActive(false);
            slot4GreenTriangleCorrect.gameObject.SetActive(false);

            slot5BlueTriangleCorrect.gameObject.SetActive(false);
            slot5GreenTriangleIncorrect.gameObject.SetActive(false);

            slot6BlueTriangleCorrect.gameObject.SetActive(false);
            slot6GreenTriangleIncorrect.gameObject.SetActive(false);

            slot7BlueTriangleCorrect.gameObject.SetActive(false);
            slot7GreenTriangleIncorrect.gameObject.SetActive(false);

            slot8BlueTriangleCorrect.gameObject.SetActive(false);
            slot8GreenTriangleIncorrect.gameObject.SetActive(false);

            tri1Prop.DeSelectSphereItemPedestel();

            tri2Prop.DeSelectSphereItemPedestal();

            sphere1Text.gameObject.SetActive(false);
            sphere2Text.gameObject.SetActive(false);
          


            blueTriangleButton.gameObject.SetActive(true);
            greenTriangleButton.gameObject.SetActive(true);

            slot1.inCorrectPlacement = false;
            slot2.inCorrectPlacement = false;
            slot3.inCorrectPlacement = false;
            slot4.inCorrectPlacement = false;
            slot5.inCorrectPlacement = false;
            slot6.inCorrectPlacement = false;
            slot7.inCorrectPlacement = false;
            slot8.inCorrectPlacement = false;


            slot1.correctPlacement = false;
            slot2.correctPlacement = false;
            slot3.correctPlacement = false;
            slot4.correctPlacement = false;
            slot5.correctPlacement = false;
            slot6.correctPlacement = false;
            slot8.correctPlacement = false;
            slot8.correctPlacement = false;

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFilled = false;
            slot4.slotFilled = false;
            slot5.slotFilled = false;
            slot6.slotFilled = false;
            slot7.slotFilled = false;
            slot8.slotFilled = false;

            progScript.runTwice = false;
            textMan.ResetPositionFlags();

        }
    }

}
