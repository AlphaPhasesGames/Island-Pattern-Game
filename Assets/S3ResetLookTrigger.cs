using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class S3ResetLookTrigger : MonoBehaviour
    {
        public BoxCollider triggerToEnable;
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerToEnable.enabled = true;
            }
        }
    }
}
