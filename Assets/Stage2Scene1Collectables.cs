using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1Collectables : MonoBehaviour
    {
        public TextMeshProUGUI uiCounter;
        public Stage2Scene1TextMan textMan;
        public int collectableCount;
        public bool allSpheresCollected;
        public bool runOnce;
        // Start is called before the first frame update
        void Start()
        {

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
                    textMan.arrayPos = 9;
                    allSpheresCollected = true;
                    runOnce = true;
                }
            }

        }
    }
}
