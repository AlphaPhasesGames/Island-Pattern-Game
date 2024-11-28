using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pattern.Quest.Alpha.Phases.Games
{
    [System.Serializable] // serialize this save data
    public class PQTMISaveData
    {
        [Header("StageProgress")] // header for the save location for the robot
        public int current_stage; // int to hold the level number
        public Vector3 player_position_save;
        public bool s1_s1_as;
        public bool s1_s2_as;
        public bool s2_s1_as;
        public bool s2_s2_as;
        [Header("StageTasks")] // header for the save location for the robot       
        public int task_number;

        //  public int task_number_crew_quarter;
        //  public int task_number_comms_room;
        //  public int task_number_dock;
        // public int task_number_ship;

    }
    
    public class PatternQuestMain : MonoBehaviour
    {
  
  

            #region global code
            [SerializeField, Header("Initial State Data")]
            PQTMISaveData pQTMISaveData1; // get access to save section of this script
            public CharacterController charCont;
            public Vector3 posOfPlayer;
            public int taskNumber;
        //   public int taskNumberCrewQuarters;
        //  public int taskNumberCommsRoom;
        // public int taskNumberDock;
        //   public int taskNumberShip;

          
            public GameObject playerRobot;

            public int currentStage;

            public bool loadSavesOnce;
            public bool s1S1AS;
            public bool s1S2AS;
            public bool s2S1AS;
            public bool s2S2AS;

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
                playerRobot = GameObject.FindGameObjectWithTag("Player");
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
                LOLSDK.Instance.SaveState(pQTMISaveData1); // save data to cargoSaveData
                Debug.Log("Game Saved");
            }

        void RemoveMainMenuUINewGame()
        {

            currentStage = 1;
            SaveS1S1();


        }
        void RemoveMainMenuUIContinue()
        {
            //posOfPlayer = pQTMISaveData.player_position_save;
            currentStage = pQTMISaveData1.current_stage;
           // posOfPlayer = pQTMISaveData1.player_position_save;
            if (currentStage == 1)
            {
                // taskNumber = pQTMISaveData.task_number;
         
                SceneManager.LoadScene("Stage 1 Scene 1");

                playerRobot.transform.position = posOfPlayer;
                //charCont.enabled = false;
                //LoadPosition();
                // charCont.enabled = true;

            }
            
            if (currentStage == 2)
            {
                SceneManager.LoadScene("Stage 1 Scene 2");
                playerRobot.transform.position = posOfPlayer;
                Debug.Log("Loaded Stage 2");
            }
           
            if (currentStage == 3)
            {
                SceneManager.LoadScene("Stage 2 Scene 1");
                playerRobot.transform.position = posOfPlayer;
                Debug.Log("Loaded Stage 3");
            }
            if (currentStage == 4)
            {
                SceneManager.LoadScene("Stage 2 Scene 2");
                playerRobot.transform.position = posOfPlayer;
                Debug.Log("Loaded Stage 3");
            }
            Debug.Log("Loaded Save");
        }

        void OnLoad(PQTMISaveData pQTMISaveData)
            {
                JSONNode langs = SharedState.LanguageDefs;
                // Overrides serialized state data or continues with editor serialized values.
                if (pQTMISaveData != null)
                pQTMISaveData1= pQTMISaveData;
            //  currentStage = tusomSaveData.current_stage;
              
                if (pQTMISaveData1.current_stage == 1)
                {

                    if (!loadSavesOnce)
                    {
                   
                    SceneManager.LoadScene("Stage 1 Scene 1");
                    s1S1AS = pQTMISaveData1.s1_s1_as;
                    // taskNumber = sSQFESaveData.task_number;
                  
                    loadSavesOnce = true;
                        Debug.Log("Stage 1 update runs - load save data from save");
                    }

                }
               
                if (pQTMISaveData1.current_stage == 2)
                {
                    if (!loadSavesOnce)
                    {
                        SceneManager.LoadScene("Stage 1 Scene 2");
                        s1S2AS = pQTMISaveData1.s1_s2_as;
                    //   taskNumberCrewQuarters = sSQFESaveData.task_number_crew_quarter;
                    Debug.Log("Stage 2 update runs - load save data from save");
                        loadSavesOnce = true;
                    }
                }

            if (pQTMISaveData1.current_stage == 3)
            {
                if (!loadSavesOnce)
                {
                    SceneManager.LoadScene("Stage 2 Scene 1");
                    s2S1AS = pQTMISaveData1.s2_s1_as;
                    //   taskNumberCrewQuarters = sSQFESaveData.task_number_crew_quarter;
                    Debug.Log("Stage 2 update runs - load save data from save");
                    loadSavesOnce = true;
                }
            }

            if (pQTMISaveData1.current_stage == 4)
            {
                if (!loadSavesOnce)
                {
                    SceneManager.LoadScene("Stage 2 Scene 2");
                    s2S1AS = pQTMISaveData1.s2_s2_as;
                    //   taskNumberCrewQuarters = sSQFESaveData.task_number_crew_quarter;
                    Debug.Log("Stage 2 update runs - load save data from save");
                    loadSavesOnce = true;
                }
            }

            /*

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

            public void SaveS1S1()
            {
                 currentStage = 1;
                 pQTMISaveData1.current_stage = currentStage;
                 Save();
            }

            public void SaveS1S2()
            {
                 currentStage = 2;
                 pQTMISaveData1.current_stage = currentStage;
                 Save();
            }

           public void SaveS2S1()
            {
                 currentStage = 3;
                 pQTMISaveData1.current_stage = currentStage;
                 Save();
            }
        public void SaveS2S2()
        {
            currentStage = 4;
            pQTMISaveData1.current_stage = currentStage;
            Save();
        }

        public void SaveScene1Stage1()
                    {

                          pQTMISaveData1.player_position_save = posOfPlayer;
                          pQTMISaveData1.s1_s1_as = s1S1AS;

                        //sSQFESaveData.current_stage = currentStage;
                        Save();
                        Debug.Log("Forces Saved Fired");
                    }

        public void SaveScene1Stage2()
        {

            pQTMISaveData1.player_position_save = posOfPlayer;
            pQTMISaveData1.s1_s2_as = s1S2AS;

            //sSQFESaveData.current_stage = currentStage;
            Save();
            Debug.Log("Forces Saved Fired");
        }


        public void SaveScene2Stage1()
        {

            pQTMISaveData1.player_position_save = posOfPlayer;
            pQTMISaveData1.s2_s1_as = s2S1AS;

            //sSQFESaveData.current_stage = currentStage;
            Save();
            Debug.Log("Forces Saved Fired");
        }

        public void SaveScene2Stage2()
        {

            pQTMISaveData1.player_position_save = posOfPlayer;
            pQTMISaveData1.s2_s2_as = s2S2AS;

            //sSQFESaveData.current_stage = currentStage;
            Save();
            Debug.Log("Forces Saved Fired");
        }
        public void SavePosition()
                    {
                        pQTMISaveData1.player_position_save = posOfPlayer;
                        //sSQFESaveData.current_stage = currentStage;
                        Save();
                        Debug.Log("Forces Saved Fired");
                    }

                    public void LoadPosition()
                    {
                       
                        playerRobot.transform.position = pQTMISaveData1.player_position_save;
        
                        Debug.Log("Forces Load Fired");
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