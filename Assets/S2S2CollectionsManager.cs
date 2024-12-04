using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S2S2CollectionsManager : MonoBehaviour
    {
        public TextMeshProUGUI uiCounter;
        public Stage2Scene2TextMan textMan;
        public Stage2Scene2StartScript startScript;
        public PatternQuestMain main;
        public int collectableCount;
        public bool allSpheresCollected;
        public bool runOnce;
        private void Awake()
        {
            main = GameObject.FindObjectOfType<PatternQuestMain>();
        }

        // Update is called once per frame
        void Update()
        {
            uiCounter.text = collectableCount.ToString();

            if (!runOnce)
            {
                if (collectableCount == 12)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 13;
                    allSpheresCollected = true;
                    main.SaveS2S2Collectables();
                    startScript.SaveGame();
                    runOnce = true;
                }
            }

        }
    }
}
