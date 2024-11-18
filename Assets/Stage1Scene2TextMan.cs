using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2TextMan : MonoBehaviour
    {
        public PatternQuestMain main;
        public RobotController robCont;
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 1;

        public bool positionChanged; //= true;


        public GameObject pollyImage;
        public GameObject unit17Image;

        //public GameObject pollyModelToHide;
       // public GameObject pollyModelToShow;

       // public GameObject triggerBoxes;

        public GameObject[] modelArray;

        //  public GameObject textPanalParent;
        public GameObject textPanal;



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
        public Button sphere2;
        public Button sphere3;
        public Button sphere8;
        public Button sphere10;
        public Button sphere31;
        public Button sphere32;

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
            if (main.s1S2AS)
            {
                arrayPos = 12;
                ResetPositionFlags(); // Reset for any array position related changes
            }
            else
            {
                StartCoroutine(StartLevelText());
              
            }
            StartCoroutine(HideButtons());
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
                        LOLSDK.Instance.SubmitProgress(0, 20, 100);
                        submitOnce = true;
                    }


                    sphere2.gameObject.SetActive(false);
                    sphere3.gameObject.SetActive(false);
                    sphere8.gameObject.SetActive(false);
                    sphere10.gameObject.SetActive(false);
                    sphere31.gameObject.SetActive(false);
                    sphere32.gameObject.SetActive(false);

                    robCont.isCharActive = false;
                    pollyImage.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3MissionText1"); break;
                case 1:
                    backwardsButton.gameObject.SetActive(true);
                                 
                    SpeakText("stage3MissionText2ChooseCar"); break;
                case 2:
                    robCont.isCharActive = true;
                    forwardParent.gameObject.SetActive(false);
                    main.s1S2AS = true;
                    main.SaveScene1Stage2();
                    main.SaveS1S2();
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText3"); break;
                case 3:
                    StopAllCoroutines();
                    pollyImage.gameObject.SetActive(true);
                    robCont.isCharActive = false;
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3MissionText4"); break;
                case 4:
                    backwardsButton.gameObject.SetActive(true);
                    unit17Image.gameObject.SetActive(false);
                  //  pollyImage.gameObject.SetActive(true);
                    SpeakText("stage3MissionText5"); break;
                case 5: SpeakText("stage3MissionText6");
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17()); break;
                case 6:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    //StopCoroutine(DelayTextButton());
                    // HideButton();
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText7"); break;
                case 7:
                   // StopAllCoroutines();
                    backwardsButton.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText8"); break;
                case 8:

                    //textPanalParent.gameObject.SetActive(true);
                    // pollyImage.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                  //  StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText9");
                    break;
                case 9:
                  //  pollyImage.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                   // main.s1S1AS = true;
                   // main.SaveScene1Stage1();
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText10");
                    break;
                case 10:
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    // forwardButton.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText11"); break;
                case 11:
                    backwardsButton.gameObject.SetActive(true);
                    SpeakText("stage3MissionText12"); break;

                case 12:

                    textPanal.gameObject.SetActive(false);
                    // charCont.enabled = false;
                    // forwardParent.gameObject.SetActive(false);
                    // backwardsButton.gameObject.SetActive(false);
                    break;
                case 13:
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

        private void ResetPositionFlags()
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

        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(5);
            robCont.isCharActive = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 12;
            Debug.Log("This start coRoutine Runs");

        }
        public IEnumerator HideButtons()
        {
            yield return new WaitForSeconds(0.2f);
            sphere2.gameObject.SetActive(false);
            sphere3.gameObject.SetActive(false);
            sphere8.gameObject.SetActive(false);
            sphere10.gameObject.SetActive(false);
            sphere31.gameObject.SetActive(false);
            sphere32.gameObject.SetActive(false);

        }
      
        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage3MissionText{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"Intro Text {textIndex} Button is pressed");
        }

        private void SpeakText(string textKey)
        {
            LOLSDK.Instance.SpeakText(textKey);
        }


        public void ResetBools()
        {
            Array.Fill(textBools, false);
        }
    }
}
