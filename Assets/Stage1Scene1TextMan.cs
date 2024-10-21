using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{

    public class Stage1Scene1TextMan : MonoBehaviour
    {
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 1;

        public GameObject pollyImage;
        public GameObject unit17Image;

        public GameObject[] modelArray;

        public GameObject textPanalParent;
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


        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);

            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;  // Adjust index to match textButton number
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }
           
            StartCoroutine(StartLevelText());
        }
        // Start is called before the first frame update

        void Start()
        {
            arrayPos = 0;
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {
            if (!hasScrolled)
            {
                // Deactivate all previous text objects
                foreach (var obj in modelArray)
                {
                    obj.SetActive(false);
                }

                // Activate the current text object
                if (arrayPos >= 0 && arrayPos < modelArray.Length)
                {
                    modelArray[arrayPos].SetActive(true);
                }

                hasScrolled = true;
            }
          
            if (!textBools[arrayPos])
            {
                HandleArrayPosActions();
                textBools[arrayPos] = true;
            }


        }

        private void HandleArrayPosActions()
        {
            switch (arrayPos)
            {
                case 0:
                    if (!submitOnce)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 0, 100);
                        submitOnce = true;
                    }
                    unit17Image.gameObject.SetActive(true);
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage3MissionText1"); break;
                case 1:
                    backwardsButton.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(false);
                    //StopCoroutine(DelayTextButton());
                    HideButton();
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage3MissionText2ChooseCar"); break;
                case 2:
                    SpeakText("stage3MissionText3"); break;
                case 3:
                    SpeakText("stage3MissionText4"); break;
                case 4:
                    

                    SpeakText("stage3MissionText5"); break;
                case 5: SpeakText("stage3MissionText6"); break;
                case 6: SpeakText("stage3MissionText7"); break;
                case 7: SpeakText("stage3MissionText8"); break;
                case 8: SpeakText("stage3MissionText9");
                    forwardButton.gameObject.SetActive(false);
                    break;
                case 9:
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    break;
                    //SpeakText("stage3MissionText10"); 
                    /*case 10:
                        SpeakText("stage3MissionText11"); break;
                    // StartCoroutine(MoveToBlankInvislbePanal()); break;
                    case 11:
                        backwardsButton.gameObject.SetActive(false);
                        //textPanal.gameObject.SetActive(true);
                        //forwardParent.gameObject.SetActive(false);
                       // StartCoroutine(MoveToBlankInvislbePanal());
                        SpeakText("stage3MissionText12"); break;
                    case 12:
                        SpeakText("stage3MissionText13"); break;
                    case 13:
                        SpeakText("stage3MissionText14"); break;
                    case 14:
                        SpeakText("stage3MissionText15");
                        break;
                    case 15:
                        SpeakText("stage3MissionText16");
                        break;
                    case 16:

                        break;
                    */
            }
        }

        public void ProgressTextForward()
        {
            arrayPos++;
            StartCoroutine(DelayTextButton());
            hasScrolled = false;
            forwardButton.gameObject.SetActive(false);
        }


        public void ProgressTextBack()
        {

            arrayPos--;
            hasScrolled = false;
            Array.Fill(textBools, false);
        }

        public void HideButton()
        {
            forwardParent.gameObject.SetActive(false);
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
            textPanalParent.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(5);
            textPanal.gameObject.SetActive(false);
            arrayPos = 9;
            Debug.Log("This start coRoutine Runs");

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