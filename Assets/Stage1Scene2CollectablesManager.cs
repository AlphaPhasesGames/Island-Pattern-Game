using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2CollectablesManager : MonoBehaviour
    {
        public PatternQuestMain main;
        public TextMeshProUGUI uiCounter;
        public Stage1Scene2TextMan textMan;
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
                if (collectableCount == 6)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 7;
                    allSpheresCollected = true;

                    main.SaveS1S2Collectables();
                    runOnce = true;
                }
            }

        }
    }
}
