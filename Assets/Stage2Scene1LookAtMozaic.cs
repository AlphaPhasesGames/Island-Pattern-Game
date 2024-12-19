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

        public bool hasViewedPedastal;

        public GameObject sphere1Text;
        public GameObject sphere2Text;
        public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;

        public GameObject slot1CircleCorrect;
        public GameObject slot1Circle2;
        public GameObject slot1Triangle;
        public GameObject slot1Square;
        public GameObject slot1Triangle2;
        public GameObject slot1Triangle3;

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

       
        public Button circleButton;
        public Button circle2Button;
        public Button triangleButton;
        public Button squareButton;
        public Button triangle2Button;
        public Button triangle3Button;
        
        public GameObject slot1CircleImage2;
        public GameObject slot1Circle1Image;
        public GameObject slot1TriangleImage;
        public GameObject slot1SquareImage;
        public GameObject slot1Triangle2Image;
        public GameObject slot1Triangle3Image;

        public Stage2Scene1CircleInventoryItem circle1Prop;
        public Stage2Scene1Circle2InventoryItem circle2Prop;
        public Stage2Scene1Triangle1InventoryItem tri1Prop;
        public Stage2Scene1SquareInventoryItem squareProp;
        public Stage2Scene1Triangle2 tri2Prop;
        public Stage2Scene1Triangle3InventoryItem tri3Prop;

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


            slot1CircleCorrect.gameObject.SetActive(false);
            slot1Circle2.gameObject.SetActive(false);
            slot1Triangle.gameObject.SetActive(false);
            slot1Square.gameObject.SetActive(false);
            slot1Triangle2.gameObject.SetActive(false);
            slot1Triangle3.gameObject.SetActive(false);

            slot2Circle.gameObject.SetActive(false);
            slot2Circle2Correct.gameObject.SetActive(false);
            slot2Triangle.gameObject.SetActive(false);
            slot2Square.gameObject.SetActive(false);
            slot2Triangle2.gameObject.SetActive(false);
            slot2Triangle3.gameObject.SetActive(false);

            slot3Circle.gameObject.SetActive(false);
            slot3Circle2.gameObject.SetActive(false);
            slot3TriangleCorrect.gameObject.SetActive(false);
            slot3Square.gameObject.SetActive(false);
            slot3Triangle2.gameObject.SetActive(false);
            slot3Triangle3.gameObject.SetActive(false);

            slot4Circle.gameObject.SetActive(false);
            slot4Circle2.gameObject.SetActive(false);
            slot4Triangle.gameObject.SetActive(false);
            slot4SquareCorrect.gameObject.SetActive(false);
            slot4Triangle2.gameObject.SetActive(false);
            slot4Triangle3.gameObject.SetActive(false);

            slot5Circle.gameObject.SetActive(false);
            slot5Circle2.gameObject.SetActive(false);
            slot5Triangle.gameObject.SetActive(false);
            slot5Square.gameObject.SetActive(false);
            slot5Triangle2Correct.gameObject.SetActive(false);
            slot4Triangle3.gameObject.SetActive(false);

            slot6Circle.gameObject.SetActive(false);
            slot6Circle2.gameObject.SetActive(false);
            slot6Triangle.gameObject.SetActive(false);
            slot6Square.gameObject.SetActive(false);
            slot6Triangle2.gameObject.SetActive(false);
            slot6Triangle3Correct.gameObject.SetActive(false);

            squareProp.DeSelectSphereItemPedestal();
            tri1Prop.DeSelectSphereItemPedestel();
            circle1Prop.DeSelectSphereItemPedastel();
            tri2Prop.DeSelectSphereItemPedestal();
            circle2Prop.DeSelectSphereItemPedastel();
            tri3Prop.DeSelectSphereItem();

            sphere1Text.gameObject.SetActive(false);
            sphere2Text.gameObject.SetActive(false);
            sphere3Text.gameObject.SetActive(false);
            sphere4Text.gameObject.SetActive(false);
            sphere5Text.gameObject.SetActive(false);
            sphere6Text.gameObject.SetActive(false);

            circleButton.gameObject.SetActive(true);
            circle2Button.gameObject.SetActive(true);
            triangleButton.gameObject.SetActive(true);
            triangle2Button.gameObject.SetActive(true);
            triangle3Button.gameObject.SetActive(true);
            squareButton.gameObject.SetActive(true);

            slot1.inCorrectPlacement = false;
            slot2.inCorrectPlacement = false;
            slot3.inCorrectPlacement = false;
            slot4.inCorrectPlacement = false;
            slot5.inCorrectPlacement = false;
            slot6.inCorrectPlacement = false;

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFilled = false;
            slot4.slotFilled = false;
            slot5.slotFilled = false;
            slot6.slotFilled = false;

            progScript.runTwice = false;
            textMan.ResetPositionFlags();

        }
    }

}
