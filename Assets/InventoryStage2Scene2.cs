using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class InventoryStage2Scene2 : MonoBehaviour
    {
        public GameObject invUIPanal; // declare gameobject for UI inventory panal

        public Stage2Scene2Circle1InvItem circle1ItemScript;
        public Stage2Scene2TriangleInventoryItem triangle1ItemScript;
        public Stage2Scene2Hexagon1InvItem hex1ItemScript;
        public Stage2Scene2Triangle1InventoryItem triangle2ItemScript;
        public Stage2Scene2SquareInventoryItem square1ItemScript;
        public Stage2Scene2Hexagon2InvItem hex2ItemsScript;
        public Stage2Scene2Circle2InvItem circle2ItemScript;
        public Stage2Scene2Hexagon3InvItem hex3ItemScript;
        public StageScene2Square2InvItem square2InvItemScript;
        public StageScene2Circle3InvItem circle3InvItemScript;
        public StageScene2Square3InvItem square3InvItemScript;
        public Stage2Scene2Triangle3InvItem triangle3InvItemScript;


        //   public Stage1Scene1Number14InvProperties no14Prop;

        // public GameObject sphereNumber1Button;

        public Button closeInv;
        public Button openInv;


        public bool isInvOpen; // bool to check is the inventory is open 
        public bool resetBools; // this book
        public bool stopRepeat;
        public bool stopRepeat2;


        public bool allItemsCollected;

        private void Awake()
        {
            resetBools = true;
            openInv.onClick.AddListener(OpenInventory);
            closeInv.onClick.AddListener(OpenInventory);
        }
        // Update is called once per frame

        void Update()
        {


            if (isInvOpen) // if stopRepeat bool is fasle, execute code
            {
                if (!stopRepeat) // if inventory is open
                {
                    invUIPanal.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
                }
            }
            else
            {
                if (!stopRepeat2) // if stopRepeat 2 is false
                {
                    invUIPanal.gameObject.SetActive(false); // hide INV UI
                    Debug.Log("Inv Consta Resetting");
                    stopRepeat2 = true; // set stopRepeat 2 to true to stop it firing over and over
                }

            }

            if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetMouseButtonDown(1)))
            {

                circle1ItemScript.DeSelectSphereItem();
                triangle1ItemScript.DeSelectSphereItem();
                hex1ItemScript.DeSelectSphereItem();
                triangle2ItemScript.DeSelectSphereItem();
                square1ItemScript.DeSelectSphereItem();
                hex2ItemsScript.DeSelectSphereItem();
                circle2ItemScript.DeSelectSphereItem();
                hex3ItemScript.DeSelectSphereItem();
                square2InvItemScript.DeSelectSphereItem();
                circle3InvItemScript.DeSelectSphereItem();
                square3InvItemScript.DeSelectSphereItem();
                triangle3InvItemScript.DeSelectSphereItem();
            }
        }


        //Function for opening the inventory
        public void OpenInventory()
        {
            isInvOpen = !isInvOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
                                 //   robCont.StopRobotMoving();
        }
    }
}
