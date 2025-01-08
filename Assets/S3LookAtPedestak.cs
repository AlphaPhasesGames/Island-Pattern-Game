using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class S3LookAtPedestak : MonoBehaviour
    {

        public Stage3TextMan textMan;
        public Stage3CollectablesManager collectMan;
        public Stage3ProgressionManager progScript;
        public BoxCollider triggerCollider;
        public Camera playerCamToDisable;
        public Camera pedastalCam;
        public Button closeButton;
        public Button resetButton;
        public RobotController robCont;
        public GameObject robotToHide;
        public bool hasViewedPedastal;
        public GameObject invPanal;
        public Stage3NumberPlacementSlot1 slot1;
        public Stage3NumberPlacementSlot2 slot2;
        public Stage3NumberPlacementSlot3 slot3;
        public Stage3NumberPlacementSlot4 slot4;
        public Stage3NumberPlacementSlot5 slot5;
        public Stage3NumberPlacementSlot6 slot6;
        public Stage3NumberPlacementSlot7 slot7;
        public Stage3NumberPlacementSlot8 slot8;
        public Stage3NumberPlacementSlot9 slot9;
        public Stage3NumberPlacementSlot10 slot10;
        public Stage3NumberPlacementSlot11 slot11;
        public Stage3NumberPlacementSlot12 slot12;

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

        public GameObject slot2No1;
        public GameObject slot2No4;
        public GameObject slot2No7;
        public GameObject slot2No10;
        public GameObject slot2No13;
        public GameObject slot2No16;
        public GameObject slot2No19;
        public GameObject slot2No22;
        public GameObject slot2No25;
        public GameObject slot2No28;
        public GameObject slot2No31;
        public GameObject slot2No34;


        public GameObject slot3No1;
        public GameObject slot3No4;
        public GameObject slot3No7;
        public GameObject slot3No10;
        public GameObject slot3No13;
        public GameObject slot3No16;
        public GameObject slot3No19;
        public GameObject slot3No22;
        public GameObject slot3No25;
        public GameObject slot3No28;
        public GameObject slot3No31;
        public GameObject slot3No34;

        public GameObject slot4No1;
        public GameObject slot4No4;
        public GameObject slot4No7;
        public GameObject slot4No10;
        public GameObject slot4No13;
        public GameObject slot4No16;
        public GameObject slot4No19;
        public GameObject slot4No22;
        public GameObject slot4No25;
        public GameObject slot4No28;
        public GameObject slot4No31;
        public GameObject slot4No34;

        public GameObject slot5No1;
        public GameObject slot5No4;
        public GameObject slot5No7;
        public GameObject slot5No10;
        public GameObject slot5No13;
        public GameObject slot5No16;
        public GameObject slot5No19;
        public GameObject slot5No22;
        public GameObject slot5No25;
        public GameObject slot5No28;
        public GameObject slot5No31;
        public GameObject slot5No34;

        public GameObject slot6No1;
        public GameObject slot6No4;
        public GameObject slot6No7;
        public GameObject slot6No10;
        public GameObject slot6No13;
        public GameObject slot6No16;
        public GameObject slot6No19;
        public GameObject slot6No22;
        public GameObject slot6No25;
        public GameObject slot6No28;
        public GameObject slot6No31;
        public GameObject slot6No34;

        public GameObject slot7No1;
        public GameObject slot7No4;
        public GameObject slot7No7;
        public GameObject slot7No10;
        public GameObject slot7No13;
        public GameObject slot7No16;
        public GameObject slot7No19;
        public GameObject slot7No22;
        public GameObject slot7No25;
        public GameObject slot7No28;
        public GameObject slot7No31;
        public GameObject slot7No34;

        public GameObject slot8No1;
        public GameObject slot8No4;
        public GameObject slot8No7;
        public GameObject slot8No10;
        public GameObject slot8No13;
        public GameObject slot8No16;
        public GameObject slot8No19;
        public GameObject slot8No22;
        public GameObject slot8No25;
        public GameObject slot8No28;
        public GameObject slot8No31;
        public GameObject slot8No34;

        public GameObject slot9No1;
        public GameObject slot9No4;
        public GameObject slot9No7;
        public GameObject slot9No10;
        public GameObject slot9No13;
        public GameObject slot9No16;
        public GameObject slot9No19;
        public GameObject slot9No22;
        public GameObject slot9No25;
        public GameObject slot9No28;
        public GameObject slot9No31;
        public GameObject slot9No34;

        public GameObject slot10No1;
        public GameObject slot10No4;
        public GameObject slot10No7;
        public GameObject slot10No10;
        public GameObject slot10No13;
        public GameObject slot10No16;
        public GameObject slot10No19;
        public GameObject slot10No22;
        public GameObject slot10No25;
        public GameObject slot10No28;
        public GameObject slot10No31;
        public GameObject slot10No34;

        public GameObject slot11No1;
        public GameObject slot11No4;
        public GameObject slot11No7;
        public GameObject slot11No10;
        public GameObject slot11No13;
        public GameObject slot11No16;
        public GameObject slot11No19;
        public GameObject slot11No22;
        public GameObject slot11No25;
        public GameObject slot11No28;
        public GameObject slot11No31;
        public GameObject slot11No34;

        public GameObject slot12No1;
        public GameObject slot12No4;
        public GameObject slot12No7;
        public GameObject slot12No10;
        public GameObject slot12No13;
        public GameObject slot12No16;
        public GameObject slot12No19;
        public GameObject slot12No22;
        public GameObject slot12No25;
        public GameObject slot12No28;
        public GameObject slot12No31;
        public GameObject slot12No34;

        public GameObject slotNo1Button;
        public GameObject slotNo2Button;
        public GameObject slotNo3Button;
        public GameObject slotNo4Button;
        public GameObject slotNo5Button;
        public GameObject slotNo6Button;
        public GameObject slotNo7Button;
        public GameObject slotNo8Button;
        public GameObject slotNo9Button;
        public GameObject slotNo10Button;
        public GameObject slotNo11Button;
        public GameObject slotNo12Button;

        public GameObject slotNo1ButtonText;
        public GameObject slotNo2ButtonText;
        public GameObject slotNo3ButtonText;
        public GameObject slotNo4ButtonText;
        public GameObject slotNo5ButtonText;
        public GameObject slotNo6ButtonText;
        public GameObject slotNo7ButtonText;
        public GameObject slotNo8ButtonText;
        public GameObject slotNo9ButtonText;
        public GameObject slotNo10ButtonText;
        public GameObject slotNo11ButtonText;
        public GameObject slotNo12ButtonText;

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

        private void ClosePedastalVeiw()
        {
            robCont.isCharActive = true;
            robotToHide.gameObject.SetActive(true);
            textMan.positionChanged = true;
            playerCamToDisable.enabled = true;
            pedastalCam.enabled = false;
            triggerCollider.enabled = true;
            resetButton.gameObject.SetActive(true);
            closeButton.gameObject.SetActive(false);
            textMan.arrayPos = 26;
        }

        public void ClosePedastalVeiwEnd()
        {

          
            invPanal.gameObject.SetActive(false);
            resetButton.gameObject.SetActive(false);
            closeButton.gameObject.SetActive(false);
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

            slot2No1.gameObject.SetActive(false);
            slot2No4.gameObject.SetActive(false);
            slot2No7.gameObject.SetActive(false);
            slot2No10.gameObject.SetActive(false);
            slot2No13.gameObject.SetActive(false);
            slot2No16.gameObject.SetActive(false);
            slot2No19.gameObject.SetActive(false);
            slot2No22.gameObject.SetActive(false);
            slot2No25.gameObject.SetActive(false);
            slot2No28.gameObject.SetActive(false);
            slot2No31.gameObject.SetActive(false);
            slot2No34.gameObject.SetActive(false);

            slot3No1.gameObject.SetActive(false);
            slot3No4.gameObject.SetActive(false);
            slot3No7.gameObject.SetActive(false);
            slot3No10.gameObject.SetActive(false);
            slot3No13.gameObject.SetActive(false);
            slot3No16.gameObject.SetActive(false);
            slot3No19.gameObject.SetActive(false);
            slot3No22.gameObject.SetActive(false);
            slot3No25.gameObject.SetActive(false);
            slot3No28.gameObject.SetActive(false);
            slot3No31.gameObject.SetActive(false);
            slot3No34.gameObject.SetActive(false);

            slot4No1.gameObject.SetActive(false);
            slot4No4.gameObject.SetActive(false);
            slot4No7.gameObject.SetActive(false);
            slot4No10.gameObject.SetActive(false);
            slot4No13.gameObject.SetActive(false);
            slot4No16.gameObject.SetActive(false);
            slot4No19.gameObject.SetActive(false);
            slot4No22.gameObject.SetActive(false);
            slot4No25.gameObject.SetActive(false);
            slot4No28.gameObject.SetActive(false);
            slot4No31.gameObject.SetActive(false);
            slot4No34.gameObject.SetActive(false);

            slot5No1.gameObject.SetActive(false);
            slot5No4.gameObject.SetActive(false);
            slot5No7.gameObject.SetActive(false);
            slot5No10.gameObject.SetActive(false);
            slot5No13.gameObject.SetActive(false);
            slot5No16.gameObject.SetActive(false);
            slot5No19.gameObject.SetActive(false);
            slot5No22.gameObject.SetActive(false);
            slot5No25.gameObject.SetActive(false);
            slot5No28.gameObject.SetActive(false);
            slot5No31.gameObject.SetActive(false);
            slot5No34.gameObject.SetActive(false);

            slot6No1.gameObject.SetActive(false);
            slot6No4.gameObject.SetActive(false);
            slot6No7.gameObject.SetActive(false);
            slot6No10.gameObject.SetActive(false);
            slot6No13.gameObject.SetActive(false);
            slot6No16.gameObject.SetActive(false);
            slot6No19.gameObject.SetActive(false);
            slot6No22.gameObject.SetActive(false);
            slot6No25.gameObject.SetActive(false);
            slot6No28.gameObject.SetActive(false);
            slot6No31.gameObject.SetActive(false);
            slot6No34.gameObject.SetActive(false);

            slot7No1.gameObject.SetActive(false);
            slot7No4.gameObject.SetActive(false);
            slot7No7.gameObject.SetActive(false);
            slot7No10.gameObject.SetActive(false);
            slot7No13.gameObject.SetActive(false);
            slot7No16.gameObject.SetActive(false);
            slot7No19.gameObject.SetActive(false);
            slot7No22.gameObject.SetActive(false);
            slot7No25.gameObject.SetActive(false);
            slot7No28.gameObject.SetActive(false);
            slot7No31.gameObject.SetActive(false);
            slot7No34.gameObject.SetActive(false);

            slot8No1.gameObject.SetActive(false);
            slot8No4.gameObject.SetActive(false);
            slot8No7.gameObject.SetActive(false);
            slot8No10.gameObject.SetActive(false);
            slot8No13.gameObject.SetActive(false);
            slot8No16.gameObject.SetActive(false);
            slot8No19.gameObject.SetActive(false);
            slot8No22.gameObject.SetActive(false);
            slot8No25.gameObject.SetActive(false);
            slot8No28.gameObject.SetActive(false);
            slot8No31.gameObject.SetActive(false);
            slot8No34.gameObject.SetActive(false);

            slot9No1.gameObject.SetActive(false);
            slot9No4.gameObject.SetActive(false);
            slot9No7.gameObject.SetActive(false);
            slot9No10.gameObject.SetActive(false);
            slot9No13.gameObject.SetActive(false);
            slot9No16.gameObject.SetActive(false);
            slot9No19.gameObject.SetActive(false);
            slot9No22.gameObject.SetActive(false);
            slot9No25.gameObject.SetActive(false);
            slot9No28.gameObject.SetActive(false);
            slot9No31.gameObject.SetActive(false);
            slot9No34.gameObject.SetActive(false);

            slot10No1.gameObject.SetActive(false);
            slot10No4.gameObject.SetActive(false);
            slot10No7.gameObject.SetActive(false);
            slot10No10.gameObject.SetActive(false);
            slot10No13.gameObject.SetActive(false);
            slot10No16.gameObject.SetActive(false);
            slot10No19.gameObject.SetActive(false);
            slot10No22.gameObject.SetActive(false);
            slot10No25.gameObject.SetActive(false);
            slot10No28.gameObject.SetActive(false);
            slot10No31.gameObject.SetActive(false);
            slot10No34.gameObject.SetActive(false);

            slot11No1.gameObject.SetActive(false);
            slot11No4.gameObject.SetActive(false);
            slot11No7.gameObject.SetActive(false);
            slot11No10.gameObject.SetActive(false);
            slot11No13.gameObject.SetActive(false);
            slot11No16.gameObject.SetActive(false);
            slot11No19.gameObject.SetActive(false);
            slot11No22.gameObject.SetActive(false);
            slot11No25.gameObject.SetActive(false);
            slot11No28.gameObject.SetActive(false);
            slot11No31.gameObject.SetActive(false);
            slot11No34.gameObject.SetActive(false);

            slot12No1.gameObject.SetActive(false);
            slot12No4.gameObject.SetActive(false);
            slot12No7.gameObject.SetActive(false);
            slot12No10.gameObject.SetActive(false);
            slot12No13.gameObject.SetActive(false);
            slot12No16.gameObject.SetActive(false);
            slot12No19.gameObject.SetActive(false);
            slot12No22.gameObject.SetActive(false);
            slot12No25.gameObject.SetActive(false);
            slot12No28.gameObject.SetActive(false);
            slot12No31.gameObject.SetActive(false);
            slot12No34.gameObject.SetActive(false);

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

           slotNo1Button.gameObject.SetActive(true);
           slotNo2Button.gameObject.SetActive(true);
           slotNo3Button.gameObject.SetActive(true);
           slotNo4Button.gameObject.SetActive(true);
           slotNo5Button.gameObject.SetActive(true);
           slotNo6Button.gameObject.SetActive(true);
           slotNo7Button.gameObject.SetActive(true);
           slotNo8Button.gameObject.SetActive(true);
           slotNo9Button.gameObject.SetActive(true);
           slotNo10Button.gameObject.SetActive(true);
           slotNo11Button.gameObject.SetActive(true);
           slotNo12Button.gameObject.SetActive(true);


            slotNo1ButtonText.gameObject.SetActive(false);
            slotNo2ButtonText.gameObject.SetActive(false);
            slotNo3ButtonText.gameObject.SetActive(false);
            slotNo4ButtonText.gameObject.SetActive(false);
            slotNo5ButtonText.gameObject.SetActive(false);
            slotNo6ButtonText.gameObject.SetActive(false);
            slotNo7ButtonText.gameObject.SetActive(false);
            slotNo8ButtonText.gameObject.SetActive(false);
            slotNo9ButtonText.gameObject.SetActive(false);
            slotNo10ButtonText.gameObject.SetActive(false);
            slotNo11ButtonText.gameObject.SetActive(false);
            slotNo12ButtonText.gameObject.SetActive(false);

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

            progScript.runTwice = false;
            textMan.ResetPositionFlags();

        }
    }
}
