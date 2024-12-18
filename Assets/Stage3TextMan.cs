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
        public S3LookAtPedestak lookPed;
        //    public GameObject pollyImage;
        //   public GameObject unit17Image;

        public GameObject collectabelUI;

        public GameObject[] modelArray;

        
        public GameObject textPanal;

        public Animator boat;
        public Animator blackAnim;
        public GameObject blackFade;

        public GameObject stairsPath1;
        public GameObject stairsPath2;
        public GameObject boxesPath2;
        public GameObject boxesPath1;

        public Camera templeViewCam;
        public Camera playerCam;
        public Camera stair1Cam;
        public Camera stair2Cam;
        public Camera dockCam;
        public Camera pedastelCam;
        public Camera boatCam;
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

           
            
            if (main.s3AS)
            {
                arrayPos = 26;
                ResetPositionFlags(); // Reset for any array position related changes
                if (main.s3TaskNo == 1)
                {
                   positionChanged = true;
                   arrayPos = 3;
                   
                }

                if (main.s3TaskNo == 2)
                {
                    stairsPath1.gameObject.SetActive(true);
                   positionChanged = true;
                    collectabelUI.gameObject.SetActive(true);
                    arrayPos = 13;
                }

                if (main.s3TaskNo == 3)
                {
                    stairsPath2.gameObject.SetActive(true);
                    boxesPath1.gameObject.SetActive(false);
                    boxesPath2.gameObject.SetActive(true);
                    collectabelUI.gameObject.SetActive(true);
                   positionChanged = true;
                   arrayPos = 16;
                }

                if (main.s3TaskNo == 4)
                {
                    stairsPath1.gameObject.SetActive(false);
                    stairsPath2.gameObject.SetActive(false);
                    boxesPath1.gameObject.SetActive(false);
                    boxesPath2.gameObject.SetActive(false);
                    collectabelUI.gameObject.SetActive(true);
                    positionChanged = true;
                    arrayPos = 18;
                }

            }
            else
            {
                StartCoroutine(StartLevelText());
            }

           
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
                       LOLSDK.Instance.SubmitProgress(0, 90, 100);
                        submitOnce = true;
                    }
                    //robCont.isCharActive = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox1"); break;
                case 1:
                    //robCont.isCharActive = true;
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    //StopCoroutine(DelayTextButton());
                 
                    SpeakText("stage3Scene1TextBox2"); break;
                case 2:
                    SpeakText("stage3Scene1TextBox3"); break;
                case 3:
                    textPanal.gameObject.SetActive(true);
                    templeViewCam.enabled = true;
                    forwardParent.gameObject.SetActive(false);
                    main.s3TaskNo = 1;
                    main.s3AS = true;
                    main.SaveTask();
                    main.SaveS3();
                    main.SaveScene3Pos();
                    StartCoroutine(MoveToBlankFromTempleCamView());
                    SpeakText("stage3Scene1TextBox4"); break;
                case 4:
                    main.s3DockFound = true;
                    main.SaveDock();
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox5"); break;
                case 5: SpeakText("stage3Scene1TextBox6");
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveCamToPedastel());
                    break;
                case 6:

                    forwardParent.gameObject.SetActive(true);
                    //StopCoroutine(DelayTextButton());
                    
                    SpeakText("stage3Scene1TextBox7"); break;
                case 7:
                  
                    backwardsButton.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox8"); break;
                case 8:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveCamToPedastel2());
                    SpeakText("stage3Scene1TextBox9");
                    break;
                case 9:
                   
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);

                    SpeakText("stage3Scene1TextBox10");
                    break;
                case 10:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(Hint1());
                    StartCoroutine(Hint2());
                    SpeakText("stage3Scene1TextBox11"); break;
                case 11:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankFromHint1());
                    SpeakText("stage3Scene1TextBox12"); break;
                case 12:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankFromHint2());
                    SpeakText("stage3Scene1TextBox13"); break;
                case 13:
                    playerCam.enabled = false;
                    stair1Cam.enabled = true; 
                    stairsPath1.gameObject.SetActive(true);
                    main.s3TaskNo = 2;
                    main.SaveTask();
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox14"); break;
                case 14:

                    collectabelUI.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    SpeakText("stage3Scene1TextBox15");
                    StartCoroutine(MoveToandFromStairs1());
                    break;
                case 15:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3Scene1TextBox16");
                    break;
                case 16:
                    main.s3TaskNo = 3;
                    main.SaveTask();
                    main.s3ShapesCollectedPath1 = true;
                    main.SaveS3CollectablesPath1();
                    stair2Cam.enabled = true;
                    playerCam.enabled = false;
                    forwardParent.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox17"); break;
                case 17:
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveBackToPlayerFromPlatform());
                    SpeakText("stage3Scene1TextBox18"); break;
                case 18:
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3Scene1TextBox19"); break;
                case 19:
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(true);
                    main.s3ShapesCollectedPath2 = true;
                    main.SaveS3CollectablesPath2();
                    main.s3TaskNo = 4;
                    main.SaveTask();
                    StartCoroutine(showDockBriefly());
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3Scene1TextBox20"); break;
                case 20:

                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);

                    SpeakText("stage3Scene1TextBox21"); break;
                case 21:
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3Scene1TextBox22");
                    break;
                case 22:
                    lookPed.ClosePedastalVeiwEnd();
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    //StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3Scene1TextBox23");
                    break;
                case 23:
                        pedastelCam.enabled = false;
                        boatCam.enabled = true;
                   // backwardsButton.gameObject.SetActive(false);
                    //StartCoroutine(MoveToBlankInvislbePanalPlatform());
                    SpeakText("stage3Scene1TextBox24");
                    break;
                case 24:
                    
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalEnd());
                    SpeakText("stage3Scene1TextBox25");
                    break;
                case 25:
                  
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

            yield return new WaitForSeconds(3);
            forwardButton.gameObject.SetActive(true);
            Debug.Log("This coRoutine Runs");

        }

        public IEnumerator StartLevelText()
        {

            yield return new WaitForSeconds(1.5f);
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

        public IEnumerator MoveToBlankInvislbePanalEnd()
        {
            yield return new WaitForSeconds(5);
            // robCont.isCharActive = true;
 
            boat.SetBool("boat", true);
            blackFade.gameObject.SetActive(true);
            blackAnim.SetBool("fade", true);
            textPanal.gameObject.SetActive(false);
            LOLSDK.Instance.SubmitProgress(0, 100, 100);
            LOLSDK.Instance.CompleteGame();
            arrayPos = 26;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveBackToPlayerFromPlatform()
        {
            yield return new WaitForSeconds(3);
            robCont.isCharActive = true;
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
            robCont.isCharActive = true;
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
