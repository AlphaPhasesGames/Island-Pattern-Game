using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3Number10InvProperties : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        // This script holds the properties and fucntions to allow the player
        // to select and hold the inventory item they wish to use

        // TUSOMMain digiWaveMain;
        public TextMeshProUGUI sphereName; //TMP text to appear at bottom of inv for gold item
        public bool playerPickedUpObject; // bool to check is the player has oicked up the item
        public bool playerHasBadgeObject;
        public GameObject invItemImage; // this gameobject holds the image for the gold item when being held
        public Button sphereButton; // this button holds the image for the gold item when in inventory
                                    // public RobotController robCont; //  this declares the script for the robot controller, so we can stop him moving when picking item from inventory
        public bool checkBool1;
        public bool checkBool2;
        public bool sphereHeld;

        // Start is called before the first frame update
        private void Start()
        {
            //digiWaveMain = FindObjectOfType<TUSOMMain>();
            sphereButton.onClick.AddListener(TurnOnAndOff); // add listener to button for gold item
        }
        // Update is called once per frame
        void Update()
        {
            if (playerPickedUpObject) // if player has picked up the gold item
            {
                invItemImage.transform.position = Input.mousePosition; // gold image sticks to mouse cursor
                sphereButton.gameObject.SetActive(false);
            }

            if (sphereHeld)
            {
                if (!checkBool1)
                {
                    SelectSphereItem();
                    checkBool1 = true;
                    checkBool2 = false;
                    Debug.Log("eScope held");
                }

            }

            else
            {
                if (!checkBool2)
                {
                    DeSelectSphereItemInv();
                    checkBool2 = true;
                    checkBool1 = false;
                    Debug.Log("eScope held");

                }

            }

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            sphereName.gameObject.SetActive(true); // show text for gold item
            Debug.Log("Mouse is over GameObject.");
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            sphereName.gameObject.SetActive(false); // hide text for gold item
            Debug.Log("Mouse is not over GameObject.");
        }

        public void SelectSphereItem() // gold fucntion for mouse click
        {
            //  robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = true; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(true); // this enables the image of the game obect to be held
            playerHasBadgeObject = true;
            sphereHeld = true;
            Debug.Log("Inv Item Picked");
        }

        public void DeSelectSphereItemInv() // gold fucntion for mouse click
        {
            if (playerPickedUpObject)
            {
                //    robCont.StopRobotMoving(); // stop the robot moving when in use
                playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
                invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
                                                          //  sphereButton.gameObject.SetActive(true);
                playerHasBadgeObject = false;
                sphereHeld = false;
                Debug.Log("Inv Item Picked");
            }
        }
        public void DeSelectSphereItem() // gold fucntion for mouse click
        {
            if (playerPickedUpObject)
            {
                //    robCont.StopRobotMoving(); // stop the robot moving when in use
                playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
                invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
                sphereButton.gameObject.SetActive(true);
                playerHasBadgeObject = false;
                sphereHeld = false;
                Debug.Log("Inv Item Picked");
            }
        }

        public void DeSelectSphereItemPedastel() // gold fucntion for mouse click
        {

            //    robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
            sphereButton.gameObject.SetActive(true);
            playerHasBadgeObject = false;
            sphereHeld = false;
            Debug.Log("Inv Item Picked");
        }

        public void TurnOnAndOff()
        {
            sphereHeld = !sphereHeld;
            //    robCont.StopRobotMoving(); // stop the robot moving when in use
        }
    }
}
