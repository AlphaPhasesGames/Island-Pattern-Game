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
        public int collectableCount;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            uiCounter.text = collectableCount.ToString();
        }
    }
}
