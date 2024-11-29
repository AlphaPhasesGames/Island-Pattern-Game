using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S2S2PitRoomTrigger : MonoBehaviour
    {

        public S2S2RuleItem ruleItem;
        public Stage2Scene2TextMan textMan;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 1;
            }
        }
    }
}
