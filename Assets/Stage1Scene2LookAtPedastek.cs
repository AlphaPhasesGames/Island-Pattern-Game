using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage1Scene2LookAtPedastek : MonoBehaviour
    {
        // Reference to the Collider component of the object
        public Stage1Scene2TextMan textMan;
        public Stage1Scene2CollectablesManager collectMan;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;

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

    //    public Stage1Scene1Number4InvProperties no2Prop;
    //    public Stage1Scene1Number6InvProperties no4Prop;
    //    public Stage1Scene1Number7InvProperties no8Prop;
   //     public Stage1Scene1Number10InvProperties no16Prop;
     //   public Stage1Scene1Number11InvProperties no32Prop;
     //   public Stage1Scene1Number14InvProperties no64Prop;

        private void Awake()
        {
            closeButton.onClick.AddListener(ClosePedastalVeiw);
            resetButton.onClick.AddListener(ResetSpeheres);
        }

        // Handle what happens when the trigger box is clicked
        private void OnTriggerBoxClicked()
        {/*
            if (!hasViewedPedastal)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 10;
                hasViewedPedastal = true;
            }
            if (hasViewedPedastal && collectMan.allSpheresCollected)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 20;
            }
*/
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

            //     no1Prop.DeSelectSphereItem();
            //     no6Prop.DeSelectSphereItem();
            //     no7Prop.DeSelectSphereItem();
            //      no10Prop.DeSelectSphereItem();
            //     no11Prop.DeSelectSphereItem();
            //       no14Prop.DeSelectSphereItem();
            //
        }
    }
}

