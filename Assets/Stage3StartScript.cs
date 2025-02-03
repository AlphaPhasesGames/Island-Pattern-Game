using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3StartScript : MonoBehaviour
    {
        public PatternQuestMain main;
        public Stage3CollectablesManager collectMan;
        public Stage3TextMan textMan;
        public CharacterController charCont;
        public RobotController robCont;
        public GameObject player;

        public GameObject uiCOllectablesPanal;

        public GameObject dockTrigger;

        public GameObject sphere1;
        public GameObject sphere4;
        public GameObject sphere7;
        public GameObject sphere10;
        public GameObject sphere13;
        public GameObject sphere16;
        public GameObject sphere19;
        public GameObject sphere22;
        public GameObject sphere25;
        public GameObject sphere28;
        public GameObject sphere31;
        public GameObject sphere34;

        public GameObject sphere1ToHide;
        public GameObject sphere4ToHide;
        public GameObject sphere7ToHide;
        public GameObject sphere10ToHide;
        public GameObject sphere13ToHide;
        public GameObject sphere16ToHide;
        public GameObject sphere19ToHide;
        public GameObject sphere22ToHide;
        public GameObject sphere25ToHide;
        public GameObject sphere28ToHide;
        public GameObject sphere31ToHide;
        public GameObject sphere34ToHide;

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

            }

            if (main.s3ShapesCollectedPath1)
            {
                StartCoroutine(ShowButtons());

                sphere1ToHide.gameObject.SetActive(false);
                sphere4ToHide.gameObject.SetActive(false);
                sphere7ToHide.gameObject.SetActive(false);
                sphere10ToHide.gameObject.SetActive(false);
                sphere13ToHide.gameObject.SetActive(false);
                sphere16ToHide.gameObject.SetActive(false);

                dockTrigger.gameObject.SetActive(false);
                collectMan.collectableCount = 6;


            }


            if (main.s3ShapesCollectedPath2)
            {
                StartCoroutine(ShowButtons2());

                sphere19ToHide.gameObject.SetActive(false);
                sphere22ToHide.gameObject.SetActive(false);
                sphere25ToHide.gameObject.SetActive(false);
                sphere28ToHide.gameObject.SetActive(false);
                sphere31ToHide.gameObject.SetActive(false);
                sphere34ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 12;


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
     
        public IEnumerator ShowButtons()
        {
            yield return new WaitForSeconds(0.2f);
            sphere1.gameObject.SetActive(true);
            sphere4.gameObject.SetActive(true);
            sphere7.gameObject.SetActive(true);
            sphere10.gameObject.SetActive(true);
            sphere13.gameObject.SetActive(true);
            sphere16.gameObject.SetActive(true);

        }

        public IEnumerator ShowButtons2()
        {
            yield return new WaitForSeconds(0.2f);
            sphere19.gameObject.SetActive(true);
            sphere22.gameObject.SetActive(true);
            sphere25.gameObject.SetActive(true);
            sphere28.gameObject.SetActive(true);
            sphere31.gameObject.SetActive(true);
            sphere34.gameObject.SetActive(true);

        }
     
    }
}

