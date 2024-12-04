using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage2Scene2StartScript : MonoBehaviour
    {
        public Stage2Scene2TextMan textMan;
        public PatternQuestMain main;
        public CharacterController charCont;
        public S2S2CollectionsManager collectMan;
        public RobotController robCont;
        public GameObject player;
        public GameObject uiCOllectablesPanal;


        public GameObject ruleButton;
        public GameObject ruleItem;
        public GameObject shapeTri1;
        public GameObject shapeTri2;
        public GameObject shapeTri3;
        public GameObject shapeCircle1;
        public GameObject shapeCircle2;
        public GameObject shapeCircle3;
        public GameObject shapeSquare1;
        public GameObject shapeSquare2;
        public GameObject shapeSquare3;

        public GameObject shapeHex1;
        public GameObject shapeHex2;
        public GameObject shapeHex3;

        public GameObject shapeTri1Hide;
        public GameObject shapeTri2ToHide;
        public GameObject shapeTri3ToHide;
        public GameObject shapeCircle1ToHide;
        public GameObject shapeCircle2ToHide;
        public GameObject shapeCircle3ToHide;
        public GameObject shapeSquare1ToHide;
        public GameObject shapeSquare2ToHide;
        public GameObject shapeSquare3ToHide;
        public GameObject shapeHex1ToHide;
        public GameObject shapeHex2ToHide;
        public GameObject shapeHex3ToHide;

        public S2S2RuleItem ruleFound;


        // Start is called before the first frame update
        void Start()
        {

            main = FindObjectOfType<PatternQuestMain>();
            main.charCont = FindObjectOfType<CharacterController>();
            main.playerRobot = player.gameObject;
            if (main.s2S2AS)
            {
               // 
                uiCOllectablesPanal.gameObject.SetActive(true);
                robCont.isCharActive = true;
                //  sphere1Butt.gameObject.SetActive(true);
                //   collectMan.collectableCount++;
                  textMan.positionChanged = true;
                  textMan.arrayPos = 17;
            }

            if (main.s2S2ShapesCollected)
            {
                shapeTri1.gameObject.SetActive(true);
                shapeTri2.gameObject.SetActive(true);
                shapeTri3.gameObject.SetActive(true);
                shapeCircle1.gameObject.SetActive(true);
                shapeCircle2.gameObject.SetActive(true);
                shapeCircle3.gameObject.SetActive(true);
                shapeSquare1.gameObject.SetActive(true);
                shapeSquare2.gameObject.SetActive(true);
                shapeSquare3.gameObject.SetActive(true);
                shapeHex1.gameObject.SetActive(true);
                shapeHex2.gameObject.SetActive(true);
                shapeHex3.gameObject.SetActive(true);
                LoadGame();

                shapeTri1Hide.gameObject.SetActive(false);
                shapeTri2ToHide.gameObject.SetActive(false);
                shapeTri3ToHide.gameObject.SetActive(false);
                shapeCircle1ToHide.gameObject.SetActive(false);
                shapeCircle2ToHide.gameObject.SetActive(false);
                shapeCircle3ToHide.gameObject.SetActive(false);
                shapeSquare1ToHide.gameObject.SetActive(false);
                shapeSquare2ToHide.gameObject.SetActive(false);
                shapeSquare3ToHide.gameObject.SetActive(false);

                shapeHex1ToHide.gameObject.SetActive(false);
                shapeHex2ToHide.gameObject.SetActive(false);
                shapeHex3ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 12;

                ruleButton.gameObject.SetActive(true);
                ruleItem.gameObject.SetActive(false);
                ruleFound.hasRule = true;
            }



        }

        // Update is called once per frame

   

        public void SaveGame()
        {

            main.posOfPlayer = player.transform.position;
            // saveData.player_position_save = main.posOfPlayer;
            main.SavePosition();
        }

        public void LoadGame()
        {
            charCont.enabled = false;
            main.LoadPosition();
            charCont.enabled = true;
        }
    }
}
