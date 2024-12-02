using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1StartScript : MonoBehaviour
    {
        public PatternQuestMain main;
        public Button sphere1Butt;
        public CollectablesManager collectMan;
        public CharacterController charCont;
        public RobotController robCont;
        public Stage1Scene1TextMan textMan;
        public GameObject player;
        public GameObject uiCOllectablesPanal;
        public GameObject pollyImage;
        public GameObject ruleButton;
        public GameObject ruleItem;
        // public GameObject sphere1;
        public GameObject sphere6;
        public GameObject sphere7;
        public GameObject sphere10;
        public GameObject sphere11;
        public GameObject sphere14;

        // public GameObject sphere1;
        public GameObject sphere6ToHide;
        public GameObject sphere7ToHide;
        public GameObject sphere10ToHide;
        public GameObject sphere11ToHide;
        public GameObject sphere14ToHide;

        // Start is called before the first frame update
        private void Awake() 
        {
            main = FindObjectOfType<PatternQuestMain>();
            textMan.positionChanged = true;
            //   main.SaveStage();
            main.charCont = FindObjectOfType<CharacterController>();
            //LoadGame();
            main.playerRobot = player.gameObject;
            if (main.s1S1AS)
            {
                LoadGame();
                uiCOllectablesPanal.gameObject.SetActive(true);
                robCont.isCharActive = true;
                sphere1Butt.gameObject.SetActive(true);
                collectMan.collectableCount++;
                textMan.positionChanged = true;
                textMan.arrayPos = 26;
                pollyImage.gameObject.SetActive(true);
            }
            if (main.s1S1SpheresCollected)
            {
               // sphere1.gameObject.SetActive(true);
                sphere6.gameObject.SetActive(true);
                sphere7.gameObject.SetActive(true);
                sphere10.gameObject.SetActive(true);
                sphere11.gameObject.SetActive(true);
                sphere14.gameObject.SetActive(true);

                sphere6ToHide.gameObject.SetActive(false);
                sphere7ToHide.gameObject.SetActive(false);
                sphere10ToHide.gameObject.SetActive(false);
                sphere11ToHide.gameObject.SetActive(false);
                sphere14ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 6;

                ruleButton.gameObject.SetActive(true);
                ruleItem.gameObject.SetActive(false);
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
