
using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1ProgressScript : MonoBehaviour
    {
        public Stage1Scene1SpherePlacementSlot1 slot1;
        public Stage1Scene1SpherePlacementSlot2 slot2;
        public Stage1Scene1SpherePlacementSlot3 slot3;
        public Stage1Scene1TextMan textMan;
        public GameObject exitTrigger;
        public bool runOnce;
        public bool runTwice;
        public bool allowPanalToCLose;
        private void Update()
        {
            if (!runOnce)
            {
                if (slot1.correctPlacement && slot2.correctPlacement && slot3.correctPlacement)
                {
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 24;
                    exitTrigger.gameObject.SetActive(true);
                    runOnce = true;
                }
            }

            if (!runTwice)
            {
                if (slot1.inCorrectPlacement || slot2.inCorrectPlacement || slot3.inCorrectPlacement)
                {
                
                    textMan.positionChanged = true; // Directly set positionChanged
                    textMan.arrayPos = 23;
                    //exitTrigger.gameObject.SetActive(true);
                    //  textMan.textPanal.gameObject.SetActive(true);
                  
                    runTwice = true;
                  //  ReppeatFail();
                }
                
            }
            

         
        }


    }
}
