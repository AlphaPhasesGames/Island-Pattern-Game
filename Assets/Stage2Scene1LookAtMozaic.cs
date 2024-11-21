using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage2Scene1LookAtMozaic : MonoBehaviour
    {

        // Reference to the Collider component of the object
       // public Stage1Scene2TextMan textMan;
       // public Stage1Scene2CollectablesManager collectMan;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;

        public bool hasViewedPedastal;

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

        public Stage2Scene2SquareInventoryItem squareProp;
        public Stage2Scene2Triangle1InventoryItem tri1Prop;
        public Stage2Scene1CircleInventoryItem circle1Prop;
        public Stage1SceneTriangle2InventoryItem tri2Prop;
        public Stage1Scene1Cicle2InventoryItem circle2Prop;
        public Stage2Scene1Triangle3InventoryItem tri3Prop;

        private void Awake()
        {
            closeButton.onClick.AddListener(ClosePedastalVeiw);
            resetButton.onClick.AddListener(ResetSpeheres);
        }

        // Handle what happens when the trigger box is clicked
        private void OnTriggerBoxClicked()
        {
            if (!hasViewedPedastal)
            {
              //  textMan.positionChanged = true;
              //  textMan.arrayPos = 3;
                hasViewedPedastal = true;
            }
            if (hasViewedPedastal )// collectMan.allSpheresCollected)
            {
              //  textMan.positionChanged = true;
             //   textMan.arrayPos = 8;
            }

            playerCamToDisable.enabled = false;
            pedastalCam.enabled = true;
            triggerCollider.enabled = false;
            closeButton.gameObject.SetActive(true);
            resetButton.gameObject.SetActive(true);
            Debug.Log("Trigger box clicked!");
            // Add your logic here (e.g., open a door, activate something, etc.)
        }

        private void ClosePedastalVeiw()
        {
            playerCamToDisable.enabled = true;
            pedastalCam.enabled = false;
            triggerCollider.enabled = true;
            resetButton.gameObject.SetActive(true);
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

            squareProp.DeSelectSphereItem();
            tri1Prop.DeSelectSphereItem();
            circle1Prop.DeSelectSphereItem();
            tri2Prop.DeSelectSphereItem();
            circle2Prop.DeSelectSphereItem();
            tri3Prop.DeSelectSphereItem();

        }
    }

}
