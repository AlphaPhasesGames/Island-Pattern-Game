using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1LookAtPedastal : MonoBehaviour
    {
        // Reference to the Collider component of the object
        public Stage1Scene1TextMan textMan;
        public CollectablesManager collectMan;
        public Stage1Scene1ProgressScript progMan;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;



        public GameObject sphere1Text;
        public GameObject sphere2Text;
        public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;

        public Stage1Scene1SpherePlacementSlot1 slot1;
        public Stage1Scene1SpherePlacementSlot2 slot2;
        public Stage1Scene1SpherePlacementSlot3 slot3;

        public bool hasViewedPedastal;

        public GameObject slot1Sphere1;
        public GameObject slot1Sphere6Correct;
        public GameObject slot1Sphere7;
        public GameObject slot1Sphere10;
        public GameObject slot1Sphere11;
        public GameObject slot1Sphere14;

        public GameObject slot2Sphere1;
        public GameObject slot2Sphere6;
        public GameObject slot2Sphere7;
        public GameObject slot2Sphere10Correct;
        public GameObject slot2Sphere11;
        public GameObject slot2Sphere14;

        public GameObject slot3Sphere1;
        public GameObject slot3Sphere6;
        public GameObject slot3Sphere7;
        public GameObject slot3Sphere10;
        public GameObject slot3Sphere11;
        public GameObject slot3Sphere14Correct;

        public Button sphere1Button;
        public Button sphere6Button;
        public Button sphere7Button;
        public Button sphere10Button;
        public Button sphere11Button;
        public Button sphere14Button;

        public GameObject slot1SphereImage1;
        public GameObject slot1Sphere6ImageCorrect;
        public GameObject slot1Sphere7Image;
        public GameObject slot1Sphere10Image;
        public GameObject slot1Sphere11Image;
        public GameObject slot1Sphere14Image;

        public Stage1Scene1Number4InvProperties no1Prop;
        public Stage1Scene1Number6InvProperties no6Prop;
        public Stage1Scene1Number7InvProperties no7Prop;
        public Stage1Scene1Number10InvProperties no10Prop;
        public Stage1Scene1Number11InvProperties no11Prop;
        public Stage1Scene1Number14InvProperties no14Prop;

        public RobotController robCont;
        public GameObject robotToHide;

        public GameObject spheresObg;
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
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 10;
                hasViewedPedastal = true;
                spheresObg.gameObject.SetActive(true);
            }
            if(hasViewedPedastal && collectMan.allSpheresCollected)
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 20;
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
               slot1Sphere1.gameObject.SetActive(false);
               slot1Sphere6Correct.gameObject.SetActive(false);
               slot1Sphere7.gameObject.SetActive(false); 
               slot1Sphere10.gameObject.SetActive(false); 
               slot1Sphere11.gameObject.SetActive(false); 
               slot1Sphere14.gameObject.SetActive(false);

            slot2Sphere1.gameObject.SetActive(false);
            slot2Sphere6.gameObject.SetActive(false);
            slot2Sphere7.gameObject.SetActive(false);
            slot2Sphere10Correct.gameObject.SetActive(false);
            slot2Sphere11.gameObject.SetActive(false);
            slot2Sphere14.gameObject.SetActive(false);

            slot3Sphere1.gameObject.SetActive(false);
            slot3Sphere6.gameObject.SetActive(false);
            slot3Sphere7.gameObject.SetActive(false);
            slot3Sphere10.gameObject.SetActive(false);
            slot3Sphere11.gameObject.SetActive(false);
            slot3Sphere14Correct.gameObject.SetActive(false);

            sphere1Button.gameObject.SetActive(true);
            sphere6Button.gameObject.SetActive(true);
            sphere7Button.gameObject.SetActive(true);
            sphere10Button.gameObject.SetActive(true);
            sphere11Button.gameObject.SetActive(true);
            sphere14Button.gameObject.SetActive(true);

            slot1SphereImage1.gameObject.SetActive(true);
            slot1Sphere6ImageCorrect.gameObject.SetActive(true);
            slot1Sphere7Image.gameObject.SetActive(true);
            slot1Sphere10Image.gameObject.SetActive(true);
            slot1Sphere11Image.gameObject.SetActive(true);
            slot1Sphere14Image.gameObject.SetActive(true);

            no1Prop.DeSelectSphereItemPed();
            no6Prop.DeSelectSphereItemPed();
            no7Prop.DeSelectSphereItemPed();
            no10Prop.DeSelectSphereItemProg();
            no11Prop.DeSelectSphereItemPed();
            no14Prop.DeSelectSphereItemPed();

            sphere1Text.gameObject.SetActive(false);
            sphere2Text.gameObject.SetActive(false);
            sphere3Text.gameObject.SetActive(false);
            sphere4Text.gameObject.SetActive(false);
            sphere5Text.gameObject.SetActive(false);
            sphere6Text.gameObject.SetActive(false);

            slot1.inCorrectPlacement = false;
            slot2.inCorrectPlacement = false;
            slot3.inCorrectPlacement = false;

            slot1.slotFilled = false;
            slot2.slotFilled = false;
            slot3.slotFilled = false;

            progMan.runTwice = false;
            textMan.ResetPositionFlags();
        }    
    }
}
