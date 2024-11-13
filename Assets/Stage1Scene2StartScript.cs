using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2StartScript : MonoBehaviour
    {
        public PatternQuestMain main;
     //   public Button sphere1Butt;
        public CollectablesManager collectMan;
        public CharacterController charCont;
        public RobotController robCont;
      //  public Stage1Scene1TextMan textMan;
        public GameObject player;
        public GameObject uiCOllectablesPanal;


        // Start is called before the first frame update
        void Start()
        {

            main = FindObjectOfType<PatternQuestMain>();
            //textMan.positionChanged = true;
            //   main.SaveStage();
            main.charCont = FindObjectOfType<CharacterController>();
            //LoadGame();
            main.playerRobot = player.gameObject;
            if (main.s1S2AS)
            {
                LoadGame();
                uiCOllectablesPanal.gameObject.SetActive(true);
                robCont.isCharActive = true;
              //  sphere1Butt.gameObject.SetActive(true);
             //   collectMan.collectableCount++;
              //  textMan.positionChanged = true;
              //  textMan.arrayPos = 26;
            }
        }

        // Update is called once per frame

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                SaveGame();
                main.SaveS1S2();
                main.SaveScene1Stage2();
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
