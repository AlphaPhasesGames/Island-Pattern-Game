using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3NumberPlacementSlot5 : MonoBehaviour
    {
        public Stage3Number1InvProperties no1InvProp;
        public Stage3Number4InvProperties no4InvProp;
        public Stage3Number7InvProperties no7InvProp;
        public Stage3Number10InvProperties no10InvProp;
        public Stage3Number13InvProperties no13InvProp;
        public Stage3Number16InvProperties no16InvProp;
        public Stage3Number19InvProperties no19InvProp;
        public Stage3Number22InvProperties no22InvProp;
        public Stage3Number25InvProperties no25InvProp;
        public Stage3Number28InvProperties no28InvProp;
        public Stage3Number31InvProperties no31InvProp;
        public Stage3Number34InvProperties no34InvProp;


        public GameObject sphereNo1;
        public GameObject sphereNo4;
        public GameObject sphereNo7;
        public GameObject sphereNo10;
        public GameObject sphereNo13;
        public GameObject sphereNo16;
        public GameObject sphereNo19;
        public GameObject sphereNo22;
        public GameObject sphereNo25;
        public GameObject sphereNo28;
        public GameObject sphereNo31;
        public GameObject sphereNo34;

        public AudioSource correctSFX;
        public AudioSource incorrectSFX;

        public bool slotFilled;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public void OnMouseDown()
        {
            if (!slotFilled)
            {
                if (no1InvProp.sphereHeld)
                {
                    sphereNo1.gameObject.SetActive(true);
                    no1InvProp.sphereButton.gameObject.SetActive(false);
                    no1InvProp.invItemImage.gameObject.SetActive(false);
                    no1InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no4InvProp.sphereHeld)
                {

                    sphereNo4.gameObject.SetActive(true);
                    no4InvProp.sphereButton.gameObject.SetActive(false);
                    no4InvProp.invItemImage.gameObject.SetActive(false);
                    no4InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no7InvProp.sphereHeld)
                {

                    sphereNo7.gameObject.SetActive(true);
                    no7InvProp.sphereButton.gameObject.SetActive(false);
                    no7InvProp.invItemImage.gameObject.SetActive(false);
                    no7InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no10InvProp.sphereHeld)
                {

                    sphereNo10.gameObject.SetActive(true);
                    no10InvProp.sphereButton.gameObject.SetActive(false);
                    no10InvProp.invItemImage.gameObject.SetActive(false);
                    no10InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no13InvProp.sphereHeld)
                {

                    sphereNo13.gameObject.SetActive(true);
                    no13InvProp.sphereButton.gameObject.SetActive(false);
                    no13InvProp.invItemImage.gameObject.SetActive(false);
                    no13InvProp.sphereHeld = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    slotFilled = true;
                    correctSFX.Play();
                }

                if (no16InvProp.sphereHeld)
                {

                    sphereNo16.gameObject.SetActive(true);
                    no16InvProp.sphereButton.gameObject.SetActive(false);
                    no16InvProp.invItemImage.gameObject.SetActive(false);
                    no16InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }


                if (no19InvProp.sphereHeld)
                {

                    sphereNo19.gameObject.SetActive(true);
                    no19InvProp.sphereButton.gameObject.SetActive(false);
                    no19InvProp.invItemImage.gameObject.SetActive(false);
                    no19InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no22InvProp.sphereHeld)
                {

                    sphereNo22.gameObject.SetActive(true);
                    no22InvProp.sphereButton.gameObject.SetActive(false);
                    no22InvProp.invItemImage.gameObject.SetActive(false);
                    no22InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no25InvProp.sphereHeld)
                {

                    sphereNo25.gameObject.SetActive(true);
                    no25InvProp.sphereButton.gameObject.SetActive(false);
                    no25InvProp.invItemImage.gameObject.SetActive(false);
                    no25InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no28InvProp.sphereHeld)
                {

                    sphereNo28.gameObject.SetActive(true);
                    no28InvProp.sphereButton.gameObject.SetActive(false);
                    no28InvProp.invItemImage.gameObject.SetActive(false);
                    no28InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no31InvProp.sphereHeld)
                {

                    sphereNo31.gameObject.SetActive(true);
                    no31InvProp.sphereButton.gameObject.SetActive(false);
                    no31InvProp.invItemImage.gameObject.SetActive(false);
                    no31InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }

                if (no34InvProp.sphereHeld)
                {

                    sphereNo34.gameObject.SetActive(true);
                    no34InvProp.sphereButton.gameObject.SetActive(false);
                    no34InvProp.invItemImage.gameObject.SetActive(false);
                    no34InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                }
            }

        }
    }
}

