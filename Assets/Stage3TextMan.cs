using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3TextMan : MonoBehaviour
    {
        public PatternQuestMain main;
        public RobotController robCont;
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 1;

        public bool positionChanged;

        //    public GameObject pollyImage;
        //   public GameObject unit17Image;

        public GameObject collectabelUI;

        public GameObject[] modelArray;

        public GameObject textPanal;

        public Camera templeViewCam;
        public Camera playerCam;
        public Camera stair1Cam;
        public Camera stair2Cam;
        public Camera dockCam;
        public Camera pedastelCam;

        public bool panalOpen;
        public bool runOnce;
        public bool runOnce2;

        public bool submitOnce;
        public bool submitOnce2;
        public GameObject forwardParent;
        public Button forwardButton;
        public Button backwardsButton;

        public Button[] textButtons;
        public bool[] textBools;


        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            main = GameObject.FindObjectOfType<PatternQuestMain>();
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;  // Adjust index to match textButton number
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }


        }
        // Start is called before the first frame update


        public void Start()
        {

            StartCoroutine(StartLevelText());
            /*
            if (main.s1S1AS)
            {
                arrayPos = 26;
                ResetPositionFlags(); // Reset for any array position related changes
                pollyModelToHide.gameObject.SetActive(false);
                pollyModelToShow.gameObject.SetActive(true);
                triggerBoxes.gameObject.SetActive(false);
            }
            else
            {
             
            }

           */
             maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {

            // Only process if the position has changed
            if (positionChanged)
            {
                positionChanged = false; // Reset flag after processing


                // Deactivate all text objects, activate only the current one
                for (int i = 0; i < modelArray.Length; i++)
                {
                    modelArray[i].SetActive(i == arrayPos);
                }

                // Handle the current array position if not yet processed
                if (!textBools[arrayPos])
                {
                    HandleArrayPosActions();
                    textBools[arrayPos] = true;
                }
            }
        }

        private void HandleArrayPosActions()
        {
            switch (arrayPos)
            {
                case 0:
                    if (!submitOnce)
                    {
                    //    LOLSDK.Instance.SubmitProgress(0, 0, 100);
                        submitOnce = true;
                    }
                    //robCont.isCharActive = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox1"); break;
                case 1:
                    //robCont.isCharActive = true;
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    //StopCoroutine(DelayTextButton());
                 
                    SpeakText("stage1Scene1TextBox2"); break;
                case 2:
                    SpeakText("stage1Scene1TextBox3"); break;
                case 3:
                    templeViewCam.enabled = true;
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankFromTempleCamView());
                    SpeakText("stage1Scene1TextBox4"); break;
                case 4:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox5"); break;
                case 5: SpeakText("stage1Scene1TextBox6");
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveCamToPedastel());
                    break;
                case 6:

                    forwardParent.gameObject.SetActive(true);
                    //StopCoroutine(DelayTextButton());
                    
                    SpeakText("stage1Scene1TextBox7"); break;
                case 7:
                  
                    backwardsButton.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox8"); break;
                case 8:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveCamToPedastel2());
                    SpeakText("stage1Scene1TextBox9");
                    break;
                case 9:
                   
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);

                    SpeakText("stage1Scene1TextBox10");
                    break;
                case 10:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(Hint1());
                    StartCoroutine(Hint2());
                    SpeakText("stage1Scene1TextBox11"); break;
                case 11:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankFromHint1());
                    SpeakText("stage1Scene1TextBox12"); break;
                case 12:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankFromHint2());
                    SpeakText("stage1Scene1TextBox13"); break;
                case 13:
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox14"); break;
                case 14:
                    collectabelUI.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    SpeakText("stage1Scene1TextBox15");
                    StartCoroutine(MoveToandFromStairs1());
                    break;
                case 15:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage1Scene1TextBox16");
                    break;
                case 16:
                    forwardParent.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox17"); break;
                case 17:
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveBackToPlayerFromPlatform());
                    SpeakText("stage1Scene1TextBox18"); break;
                case 18:
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox19"); break;
                case 19:
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(true);
                    StartCoroutine(showDockBriefly());
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage1Scene1TextBox20"); break;
                case 20:
                    forwardButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    SpeakText("stage1Scene1TextBox21"); break;
                case 21:
                    backwardsButton.gameObject.SetActive(false);
                    SpeakText("stage1Scene1TextBox22");
                    break;
                case 22:
                    StopAllCoroutines();
                    forwardParent.gameObject.SetActive(true);
                    //StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage1Scene1TextBox23");
                    break;
                case 23:
                    textPanal.gameObject.SetActive(true);
                    forwardButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    //StartCoroutine(MoveToBlankInvislbePanalPlatform());
                    SpeakText("stage1Scene1TextBox24Incorrect");
                    break;
                case 24:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage1Scene1TextBox25Correct");
                    break;
                case 25:
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    robCont.isCharActive = false;
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    break;
                case 26:
                    textPanal.gameObject.SetActive(false);
                    // charCont.enabled = false;
                    // forwardParent.gameObject.SetActive(false);
                    // backwardsButton.gameObject.SetActive(false);
                    break;
                case 27:
                    textPanal.gameObject.SetActive(false);
                    // charCont.enabled = false;
                    // forwardParent.gameObject.SetActive(false);
                    // backwardsButton.gameObject.SetActive(false);
                    break;
            }
        }

        public void ProgressTextForward()
        {
            if (arrayPos < maxLengthArray - 1)
            {
                arrayPos++;
                positionChanged = true; // Mark position as changed
                StartCoroutine(DelayTextButton());
                hasScrolled = false;
                forwardButton.gameObject.SetActive(false);
            }
        }


        public void ProgressTextBack()
        {

            if (arrayPos > minLengthArray)
            {
                arrayPos--;
                positionChanged = true; // Mark position as changed
                hasScrolled = false;
                Array.Fill(textBools, false);
            }
        }

        public void ResetPositionFlags()
        {
            Array.Fill(textBools, false); // Reset all boolean flags for text
            positionChanged = true;       // Mark position as changed for Update() processing
        }

        public void HideButton()
        {
            forwardButton.gameObject.SetActive(false);
        }

        public IEnumerator DelayTextButton()
        {

            yield return new WaitForSeconds(1);
            forwardButton.gameObject.SetActive(true);
            Debug.Log("This coRoutine Runs");

        }

        public IEnumerator StartLevelText()
        {

            yield return new WaitForSeconds(4);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator Hint1()
        {

            yield return new WaitForSeconds(15);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 11;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator Hint2()
        {

            yield return new WaitForSeconds(30);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 12;
            Debug.Log("This start coRoutine Runs");

        }
        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(5);
            robCont.isCharActive = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveBackToPlayerFromPlatform()
        {
            yield return new WaitForSeconds(3);
            stair2Cam.enabled = false;
            playerCam.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }


        public IEnumerator MoveToBlankFromHint1()
        {
            yield return new WaitForSeconds(14);
            textPanal.gameObject.SetActive(false);
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToBlankFromHint2()
        {
            yield return new WaitForSeconds(30);
            textPanal.gameObject.SetActive(false);
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToBlankInvislbePanalPlatform()
        {
            yield return new WaitForSeconds(3);
            // robCont.isCharActive = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 12;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveCamToPedastel()
        {
            yield return new WaitForSeconds(4);
            // robCont.isCharActive = true;
            dockCam.enabled = false;
            pedastelCam.enabled = true;
            yield return new WaitForSeconds(2);
            positionChanged = true;
            arrayPos = 6;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveCamToPedastel2()
        {
            yield return new WaitForSeconds(4);
            pedastelCam.enabled = false;
            playerCam.enabled = true;
            textPanal.gameObject.SetActive(false);
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToandFromStairs1()
        {
            yield return new WaitForSeconds(4);
            // robCont.isCharActive = true;
            textPanal.gameObject.SetActive(false);
            stair1Cam.enabled = false;
            playerCam.enabled = true;
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }
        public IEnumerator MoveToBlankFromTempleCamView()
        {
            yield return new WaitForSeconds(4);
            // robCont.isCharActive = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 26;
            templeViewCam.enabled = false;
            playerCam.enabled = true;
            robCont.isCharActive = true;
            Debug.Log("This start coRoutine Runs");

        }
        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage3Scene1TextBox{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"Intro Text {textIndex} Button is pressed");
        }

        private void SpeakText(string textKey)
        {
            LOLSDK.Instance.SpeakText(textKey);
        }

        public IEnumerator showDockBriefly()
        {
            dockCam.enabled = true;
            playerCam.enabled = false;
            yield return new WaitForSeconds(2);
            dockCam.enabled = false;
            playerCam.enabled = true;
        }

        public void ResetBools()
        {
            Array.Fill(textBools, false);
        }
    }
}
