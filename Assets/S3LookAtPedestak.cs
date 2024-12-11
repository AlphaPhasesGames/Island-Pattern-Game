using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class S3LookAtPedestak : MonoBehaviour
    {

        public Stage3TextMan textMan;
        public Stage3CollectablesManager collectMan;
        //  public Stage2Scene2ProgMan progScript;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;

        public bool hasViewedPedastal;

        public Stage3NumberPlacementSlot1 slot1;

        public GameObject slot1No1;
        public GameObject slot1No4;
        public GameObject slot1No7;
        public GameObject slot1No10;
        public GameObject slot1No13;
        public GameObject slot1No16;
        public GameObject slot1No19;
        public GameObject slot1No22;
        public GameObject slot1No25;
        public GameObject slot1No28;
        public GameObject slot1No31;
        public GameObject slot1No34;

        public Stage3Number1InvProperties sphereNo1Item;
        public Stage3Number4InvProperties sphereNo4Item;
        public Stage3Number7InvProperties sphereNo7Item;
        public Stage3Number10InvProperties sphereNo10Item;
        public Stage3Number13InvProperties sphereNo13Item;
        public Stage3Number16InvProperties sphereNo16Item;
        public Stage3Number19InvProperties sphereNo19Item;
        public Stage3Number22InvProperties sphereNo22Item;
        public Stage3Number25InvProperties sphereNo25Item;
        public Stage3Number28InvProperties sphereNo28Item;
        public Stage3Number31InvProperties sphereNo31Item;
        public Stage3Number34InvProperties sphereNo34Item;
        

        private void Awake()
        {
            closeButton.onClick.AddListener(ClosePedastalVeiw);
            resetButton.onClick.AddListener(ResetSpeheres);
        }


        void OnMouseDown()
        {
            OnTriggerBoxClicked();
        }

        // Handle what happens when the trigger box is clicked
        private void OnTriggerBoxClicked()
        {
            if (collectMan.allSpheresCollected)
            {
                textMan.StopAllCoroutines();
                textMan.positionChanged = true;
                textMan.arrayPos = 20;
                hasViewedPedastal = true;
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
            textMan.positionChanged = true;
            playerCamToDisable.enabled = true;
            pedastalCam.enabled = false;
            triggerCollider.enabled = true;
            resetButton.gameObject.SetActive(true);
            closeButton.gameObject.SetActive(false);
            textMan.arrayPos = 26;
        }




        public void ResetSpeheres()
        {
            slot1No1.gameObject.SetActive(false);
            slot1No4.gameObject.SetActive(false);
            slot1No7.gameObject.SetActive(false);
            slot1No10.gameObject.SetActive(false);
            slot1No13.gameObject.SetActive(false);
            slot1No16.gameObject.SetActive(false);
            slot1No19.gameObject.SetActive(false);
            slot1No22.gameObject.SetActive(false);
            slot1No25.gameObject.SetActive(false);
            slot1No28.gameObject.SetActive(false);
            slot1No31.gameObject.SetActive(false);
            slot1No34.gameObject.SetActive(false);
        }
    }
}
