using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1ShowSphere7Text : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {

        public TextMeshProUGUI sphere7Name; //TMP text to appear at bottom of inv for gold item



        public void OnPointerEnter(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            sphere7Name.gameObject.SetActive(true); // show text for gold item
            Debug.Log("Mouse is over GameObject.");
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            sphere7Name.gameObject.SetActive(false); // hide text for gold item
            Debug.Log("Mouse is not over GameObject.");
        }

    }
}
