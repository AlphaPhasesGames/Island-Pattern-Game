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


        public GameObject shapeSquare1;
        public GameObject shapeDiamond;
        public GameObject shapeHex1;

        public GameObject shapeSquare1ToHide;
        public GameObject shapeHex1ToHide;
        public GameObject shapeDiamond1ToHide;
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
                LoadGame();
                shapeSquare1.gameObject.SetActive(true);
                shapeHex1.gameObject.SetActive(true);
                shapeDiamond.gameObject.SetActive(true);
                           
                shapeSquare1ToHide.gameObject.SetActive(false);
                shapeHex1ToHide.gameObject.SetActive(false);
                shapeDiamond1ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 3;
                            
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
