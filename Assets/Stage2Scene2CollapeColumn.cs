using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2CollapeColumn : MonoBehaviour
    {
        public Rigidbody rb;
        public Stage2Scene2TextMan textman;
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                rb.isKinematic = false;
                StartCoroutine(DeleteColumn());
            }
        }

        public IEnumerator DeleteColumn()
        {
            yield return new WaitForSeconds(2f);
            textman.positionChanged = true;
            textman.arrayPos = 6;
            Destroy(this.gameObject);
        }
    } 
}
