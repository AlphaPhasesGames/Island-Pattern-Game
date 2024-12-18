using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2StartScript : MonoBehaviour
    {
        public PatternQuestMain main;
     //   public Button sphere1Butt;
        public Stage1Scene2CollectablesManager collectMan;
        public CharacterController charCont;
        public RobotController robCont;
        public Stage1Scene2TextMan textMan;
        public GameObject player;
        public GameObject uiCOllectablesPanal;
        public GameObject ruleButton;
        public GameObject ruleItem;
        public GameObject sphere2;
        public GameObject sphere3;
        public GameObject sphere8;
        public GameObject sphere10;
        public GameObject sphere31;
        public GameObject sphere32;

        public GameObject sphere2ToHide;
        public GameObject sphere3ToHide;
        public GameObject sphere8ToHide;
        public GameObject sphere10ToHide;
        public GameObject sphere31ToHide;
        public GameObject sphere32ToHide;

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
             
                Debug.Log("This start fucntion runs");
            }

            if (main.s1S2SpheresCollected)
            {
                StartCoroutine(ShowButtons());

                sphere2ToHide.gameObject.SetActive(false);
                sphere3ToHide.gameObject.SetActive(false);
                sphere8ToHide.gameObject.SetActive(false);
                sphere10ToHide.gameObject.SetActive(false);
                sphere31ToHide.gameObject.SetActive(false);
                sphere32ToHide.gameObject.SetActive(false);

                collectMan.allSpheresCollected = true;
                collectMan.collectableCount = 6;

                ruleButton.gameObject.SetActive(true);
                ruleItem.gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(ShowText());
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
            sphere2.gameObject.SetActive(true);
            sphere3.gameObject.SetActive(true);
            sphere8.gameObject.SetActive(true);
            sphere10.gameObject.SetActive(true);
            sphere31.gameObject.SetActive(true);
            sphere32.gameObject.SetActive(true);

        }

        public IEnumerator ShowText()
        {
            yield return new WaitForSeconds(0.2f);
            textMan.positionChanged = true;
            textMan.arrayPos = 5;

        }
    }
}
