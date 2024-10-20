using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class PQTMISaveData
    {
        [Header("StageProgress")] // header for the save location for the robot
        public int current_stage; // int to hold the level number

        [Header("StageTasks")] // header for the save location for the robot       
        public int task_number;
        //  public int task_number_crew_quarter;
        //  public int task_number_comms_room;
        //  public int task_number_dock;
        // public int task_number_ship;

    }
    [System.Serializable] // serialize this save data
    public class PatternQuestMain : MonoBehaviour
    {
  
  

            #region global code
            [SerializeField, Header("Initial State Data")]
            PQTMISaveData pQTMISaveData; // get access to save section of this script

            public int taskNumber;
            //   public int taskNumberCrewQuarters;
            //  public int taskNumberCommsRoom;
            // public int taskNumberDock;
            //   public int taskNumberShip;

            public int currentStage;

            public bool loadSavesOnce;


            #region "stage1stufftobecollapsed"
            [SerializeField, Header("Stage 1 Code")]
            #endregion
            JSONNode _langNode; // declare lanuage code for this game so we know if its spanish or english
            public string _langCode = "en"; // declare string for english text
            string _langCodeSpanish = "es"; // declare string for spanish text

            // public GameObject logo;

            [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options

         //   public TextMeshProUGUI newGameText; // TMP for the new game button
         //   public TextMeshProUGUI continueText; // TMP for the continue game button
                                                 //  public Animator logoAnim;


            private void Awake() // on awake of script
            {
                Application.runInBackground = false; // dont let the game run in the background
                DontDestroyOnLoad(this.gameObject);
                //  stage1Started = true;
                //    currentStage = 1;
            }

            void Start()
            {
                newGameButton.onClick.AddListener(RemoveMainMenuUINewGame); // new game button after pressing, hides the button - see script at the bottom of the script
                continueButton.onClick.AddListener(RemoveMainMenuUIContinue); ; // continune saved game button after pressing, hides the button - see script at the bottom of the script

#if UNITY_EDITOR
                ILOLSDK sdk = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
	    ILOLSDK sdk = new LoLSDK.WebGL();
#endif
                Helper.StateButtonInitialize<PQTMISaveData>(newGameButton, continueButton, OnLoad); // initialise LOLSDK helper function and attached both new game and continue buttons to it
            }



            public void Save()
            {
                LOLSDK.Instance.SaveState(pQTMISaveData); // save data to cargoSaveData
                Debug.Log("Game Saved");
            }

        void RemoveMainMenuUINewGame()
        {

            currentStage = 1;


        }
        void RemoveMainMenuUIContinue()
        {

            currentStage = pQTMISaveData.current_stage;

            if (currentStage == 1)
            {
                taskNumber = pQTMISaveData.task_number;
                SceneManager.LoadScene("Stage 1 Scene 1");

            }
            /*
            if (currentStage == 2)
            {
                SceneManager.LoadScene("Stage 2 Energy");

                Debug.Log("Loaded Stage 2");
            }

            if (currentStage == 3)
            {
                SceneManager.LoadScene("Stage 3 Increased Energy");

                Debug.Log("Loaded Stage 3");
            }
            if (currentStage == 4)
            {
                SceneManager.LoadScene("Stage 4 Transfering Energy");

                Debug.Log("Loaded Stage 4");
            }
            */
            Debug.Log("Loaded Save");
        }

        void OnLoad(PQTMISaveData ssQFESaveData)
            {
                JSONNode langs = SharedState.LanguageDefs;
                // Overrides serialized state data or continues with editor serialized values.
                if (ssQFESaveData != null)
                    pQTMISaveData = ssQFESaveData;
                //  currentStage = tusomSaveData.current_stage;

                if (currentStage == 1)
                {

                    if (!loadSavesOnce)
                    {
                        SceneManager.LoadScene("Stage 1 Scene 1");
                        // taskNumber = sSQFESaveData.task_number;
                        loadSavesOnce = true;
                        Debug.Log("Stage 1 update runs - load save data from save");
                    }

                }
                /*
                if (pQTMISaveData.current_stage == 2)
                {
                    if (!loadSavesOnce)
                    {
                        SceneManager.LoadScene("Stage 2 Energy");
                        //   taskNumberCrewQuarters = sSQFESaveData.task_number_crew_quarter;
                        Debug.Log("Stage 2 update runs - load save data from save");
                        loadSavesOnce = true;
                    }
                }


                if (pQTMISaveData.current_stage == 3)
                {

                    if (!loadSavesOnce)
                    {
                        SceneManager.LoadScene("Stage 3 Increased Energy");

                        loadSavesOnce = true;
                        Debug.Log("Stage 3 update runs - load save data from save");

                    }
                }

                if (pQTMISaveData.current_stage == 4)
                {

                    if (!loadSavesOnce)
                    {
                        SceneManager.LoadScene("Stage 4 Transfering Energy");
                        // currentStage = tusomSaveData.current_stage;
                        loadSavesOnce = true;
                        Debug.Log("Stage 4 update runs - load save data from save");
                    }
                }
                */
                Debug.Log("Load Function Called");
            }

          
           
                    public void SaveStage()
                    {
                        currentStage = 1;
                            pQTMISaveData.current_stage = currentStage;
                        //sSQFESaveData.current_stage = currentStage;
                        Save();
                        Debug.Log("Forces Saved Fired");
                    }
            /*
                   public void SaveStage2()
                   {
                       currentStage = 2;
                           pQTMISaveData.current_stage = currentStage;
                       //sSQFESaveData.current_stage = currentStage;
                       Save();
                       Debug.Log("Forces Saved Fired");
                   }

                   public void SaveStage3()
                   {
                       currentStage = 3;
                           pQTMISaveData.current_stage = currentStage;
                       //sSQFESaveData.current_stage = currentStage;
                       Save();
                       Debug.Log("Forces Saved Fired");
                   }

                   public void SaveStage4()
                   {
                       currentStage = 4;
                       pQTMISaveData.current_stage = currentStage;
                       //sSQFESaveData.current_stage = currentStage;
                       Save();
                       Debug.Log("Forces Saved Fired");
                   }
           */
            #endregion
        }
    }