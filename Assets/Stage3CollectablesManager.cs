using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3CollectablesManager : MonoBehaviour
    {
        public TextMeshProUGUI uiCounter;
        public Stage3TextMan textMan;
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
                    textMan.arrayPos = 18;
                   // main.SaveS2S1Collectables();
                    allSpheresCollected = true;
                    runOnce = true;
                }
            }

        }
    }
}