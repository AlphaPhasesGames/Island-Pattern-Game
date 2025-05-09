using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class CollectablesManager : MonoBehaviour
    {
        public TextMeshProUGUI uiCounter;
        public PatternQuestMain main;
        public Stage1Scene1TextMan textMan;
        public int collectableCount;
        public bool allSpheresCollected;
        public bool runOnce;
        // Start is called before the first frame update
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
                    textMan.arrayPos = 19;
                    allSpheresCollected = true;
                    main.SaveS1S1Collectables();
                    runOnce = true;
                }
            }
           
        }
    }
}
