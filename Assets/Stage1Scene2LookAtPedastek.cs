using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage1Scene2LookAtPedastek : MonoBehaviour
    {
        // Reference to the Collider component of the object
        public Stage1Scene2TextMan textMan;
        public Stage1Scene2CollectablesManager collectMan;
        public Stage1Scene2ProgressScript progScript;

        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;

        public Stage1Scene2SpherePlacementSlot1 slot1;
        public Stage1Scene2SPherePlacementSlot2 slot2;
        public Stage1Scene2SpherePlacementSlot3 slot3;

        public GameObject sphere1Text;
        public GameObject sphere2Text;
        public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;

        public bool hasViewedPedastal;

        public GameObject slot1Sphere2Correct;
        public GameObject slot1Sphere4;
        public GameObject slot1Sphere8;
        public GameObject slot1Sphere16;
        public GameObject slot1Sphere32;
        public GameObject slot1Sphere64;

        public GameObject slot2Sphere2;
        public GameObject slot2Sphere4;
        public GameObject slot2Sphere8Correct;
        public GameObject slot2Sphere16;
        public GameObject slot2Sphere32;
        public GameObject slot2Sphere64;

        public GameObject slot3Sphere2;
        public GameObject slot3Sphere4;
        public GameObject slot3Sphere8;
        public GameObject slot3Sphere16;
        public GameObject slot3Sphere32Correct;
        public GameObject slot3Sphere64;

        public Button sphere2Button;
        public Button sphere3Button;
        public Button sphere8Button;
        public Button sphere10Button;
        public Button sphere32Button;
        public Button sphere31Button;

        public GameObject slot1SphereImage2;
        public GameObject slot1Sphere3Image;
        public GameObject slot1Sphere8Image;
        public GameObject slot1Sphere10Image;
        public GameObject slot1Sphere31Image;
        public GameObject slot1Sphere32Image;

        public Stage1Scene2Number2InvProperties no2Prop;
        public Stage1Scene2Number3InvProperties no3Prop;
        public Stage1Scene2Number8InvProperties no8Prop;
        public Stage1Scene2Number10InvProperties no10Prop;
        public Stage1Scene2Number31InvProperties no31Prop;
        public Stage1Scene2Number32InvProperties no32Prop;

        public RobotController robCont;
        public GameObject robotToHide;
        public GameObject spheresObj;
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
                textMan.positionChanged = true;
                textMan.arrayPos = 3;
                hasViewedPedastal = true;
                spheresObj.gameObject.SetActive(true);
            }
            if (hasViewedPedastal && collectMan.allSpheresCollected)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 8;
            }

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
            slot1Sphere2Correct.gameObject.SetActive(false);
            slot1Sphere4.gameObject.SetActive(false);
            slot1Sphere8.gameObject.SetActive(false);
            slot1Sphere16.gameObject.SetActive(false);
            slot1Sphere32.gameObject.SetActive(false);
            slot1Sphere64.gameObject.SetActive(false);

            slot2Sphere2.gameObject.SetActive(false);
            slot2Sphere4.gameObject.SetActive(false);
            slot2Sphere8Correct.gameObject.SetActive(false);
            slot2Sphere16.gameObject.SetActive(false);
            slot2Sphere32.gameObject.SetActive(false);
            slot2Sphere64.gameObject.SetActive(false);

            slot3Sphere2.gameObject.SetActive(false);
            slot3Sphere4.gameObject.SetActive(false);
            slot3Sphere8.gameObject.SetActive(false);
            slot3Sphere16.gameObject.SetActive(false);
            slot3Sphere32Correct.gameObject.SetActive(false);
            slot3Sphere64.gameObject.SetActive(false);

            sphere2Button.gameObject.SetActive(true);
            sphere3Button.gameObject.SetActive(true);
            sphere8Button.gameObject.SetActive(true);
            sphere10Button.gameObject.SetActive(true);
            sphere32Button.gameObject.SetActive(true);
            sphere31Button.gameObject.SetActive(true);

            slot1SphereImage2.gameObject.SetActive(true);
            slot1Sphere3Image.gameObject.SetActive(true);
            slot1Sphere8Image.gameObject.SetActive(true);
            slot1Sphere10Image.gameObject.SetActive(true);
            slot1Sphere31Image.gameObject.SetActive(true);
            slot1Sphere32Image.gameObject.SetActive(true);

            sphere1Text.gameObject.SetActive(false);
            sphere2Text.gameObject.SetActive(false);
            sphere3Text.gameObject.SetActive(false);
            sphere4Text.gameObject.SetActive(false);
            sphere5Text.gameObject.SetActive(false);
            sphere6Text.gameObject.SetActive(false);

            no2Prop.DeSelectSphereItemPedastel();
                 no3Prop.DeSelectSphereItemPedastel();
                 no8Prop.DeSelectSphereItemPedastel();
                 no10Prop.DeSelectSphereItemPedastel();
                 no31Prop.DeSelectSphereItemPedastel();
                 no32Prop.DeSelectSphereItemPedastel();

            slot1.inCorrectPlacement = false;
            slot2.inCorrectPlacement = false;
            slot3.inCorrectPlacement = false;

            slot1.correctPlacement = false;
            slot2.correctPlacement = false;
            slot3.correctPlacement = false;

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFilled = false;

            progScript.runTwice = false;
            textMan.ResetPositionFlags();
        }
    }
}

