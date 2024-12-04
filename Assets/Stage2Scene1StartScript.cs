using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1StartScript : MonoBehaviour
    {
        public PatternQuestMain main;
        //   public Button sphere1Butt;
        public Stage2Scene1Collectables collectMan;
        public CharacterController charCont;
        public RobotController robCont;
        //  public Stage1Scene1TextMan textMan;
        public GameObject player;
        public GameObject uiCOllectablesPanal;

        public GameObject ruleButton;
        public GameObject ruleItem;
        public GameObject shapeTri1;
        public GameObject shapeTri2;
        public GameObject shapeTri3;
        public GameObject shapeCircle1;
        public GameObject shapeCircle2;
        public GameObject shapeSquare1;

        public GameObject shapeTri1Hide;
        public GameObject shapeTri2ToHide;
        public GameObject shapeTri3ToHide;
        public GameObject shapeCircle1ToHide;
        public GameObject shapeCircle2ToHide;
        public GameObject shapeSquare1ToHide;

        // Start is called before the first frame update
        void Start()
        {

            main = FindObjectOfType<PatternQuestMain>();
            //textMan.positionChanged = true;
            //   main.SaveStage();
            main.charCont = FindObjectOfType<CharacterController>();
            //LoadGame();
            main.playerRobot = player.gameObject;
            if (main.s2S1AS)
            {
                LoadGame();
                uiCOllectablesPanal.gameObject.SetActive(true);
                robCont.isCharActive = true;
                //  sphere1Butt.gameObject.SetActive(true);
                //   collectMan.collectableCount++;
                //  textMan.positionChanged = true;
                //  textMan.arrayPos = 26;
            }

            if (main.s2S1ShapesCollected)
            {
                shapeTri1.gameObject.SetActive(true);
                shapeTri2.gameObject.SetActive(true);
                shapeTri3.gameObject.SetActive(true);
                shapeCircle1.gameObject.SetActive(true);
                shapeCircle2.gameObject.SetActive(true);
                shapeSquare1.gameObject.SetActive(true);

                shapeTri1Hide.gameObject.SetActive(false);
                shapeTri2ToHide.gameObject.SetActive(false);
                shapeTri3ToHide.gameObject.SetActive(false);
                shapeCircle1ToHide.gameObject.SetActive(false);
                shapeCircle2ToHide.gameObject.SetActive(false);
                shapeSquare1ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 6;

                ruleButton.gameObject.SetActive(true);
                ruleItem.gameObject.SetActive(false);
            }

        }

        // Update is called once per frame

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                SaveGame();
                main.SaveS2S1();
                main.SaveScene2Stage1();
            }

            if (Input.GetKeyDown(KeyCode.F6))
            {

                LoadGame();


            }


        }

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
