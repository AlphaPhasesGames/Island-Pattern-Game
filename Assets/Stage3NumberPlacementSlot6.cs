using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3NumberPlacementSlot6 : MonoBehaviour
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

        public GameObject slotNo1ButtonText;
        public GameObject slotNo2ButtonText;
        public GameObject slotNo3ButtonText;
        public GameObject slotNo4ButtonText;
        public GameObject slotNo5ButtonText;
        public GameObject slotNo6ButtonText;
        public GameObject slotNo7ButtonText;
        public GameObject slotNo8ButtonText;
        public GameObject slotNo9ButtonText;
        public GameObject slotNo10ButtonText;
        public GameObject slotNo11ButtonText;
        public GameObject slotNo12ButtonText;

        public GameObject slotNo1Button;
        public GameObject slotNo2Button;
        public GameObject slotNo3Button;
        public GameObject slotNo4Button;
        public GameObject slotNo5Button;
        public GameObject slotNo6Button;
        public GameObject slotNo7Button;
        public GameObject slotNo8Button;
        public GameObject slotNo9Button;
        public GameObject slotNo10Button;
        public GameObject slotNo11Button;
        public GameObject slotNo12Button;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public bool no1;
        public bool no2;
        public bool no3;
        public bool no4;
        public bool no5;
        public bool no6;
        public bool no7;
        public bool no8;
        public bool no9;
        public bool no10;
        public bool no11;
        public bool no12;

        public void OnMouseDown()
        {

            if (slotFilled && no1)
            {
                if (!no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo1.gameObject.SetActive(false);
                    no1InvProp.sphereButton.gameObject.SetActive(true);
                    no1 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no2)
            {
                if (!no1InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo4.gameObject.SetActive(false);
                    no4InvProp.sphereButton.gameObject.SetActive(true);
                    no2 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no3)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo7.gameObject.SetActive(false);
                    no7InvProp.sphereButton.gameObject.SetActive(true);
                    no3 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no4)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo10.gameObject.SetActive(false);
                    no10InvProp.sphereButton.gameObject.SetActive(true);
                    no4 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no5)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo13.gameObject.SetActive(false);
                    no13InvProp.sphereButton.gameObject.SetActive(true);
                    no5 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no6)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo16.gameObject.SetActive(false);
                    no16InvProp.sphereButton.gameObject.SetActive(true);
                    no6 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }


            else if (slotFilled && no7)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo19.gameObject.SetActive(false);
                    no19InvProp.sphereButton.gameObject.SetActive(true);
                    no7 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no8)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo22.gameObject.SetActive(false);
                    no22InvProp.sphereButton.gameObject.SetActive(true);
                    no8 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no9)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo25.gameObject.SetActive(false);
                    no25InvProp.sphereButton.gameObject.SetActive(true);
                    no9 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no10)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no31InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo28.gameObject.SetActive(false);
                    no28InvProp.sphereButton.gameObject.SetActive(true);
                    no10 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no11)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no34InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo31.gameObject.SetActive(false);
                    no31InvProp.sphereButton.gameObject.SetActive(true);
                    no11 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no12)
            {
                if (!no1InvProp.sphereHeld && !no4InvProp.sphereHeld && !no7InvProp.sphereHeld && !no10InvProp.sphereHeld && !no13InvProp.sphereHeld && !no16InvProp.sphereHeld && !no19InvProp.sphereHeld && !no22InvProp.sphereHeld && !no25InvProp.sphereHeld && !no28InvProp.sphereHeld && !no31InvProp.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    sphereNo34.gameObject.SetActive(false);
                    no34InvProp.sphereButton.gameObject.SetActive(true);
                    no12 = false;
                    slotFilled = false;
                    slotNo1ButtonText.gameObject.SetActive(false);
                    slotNo2ButtonText.gameObject.SetActive(false);
                    slotNo3ButtonText.gameObject.SetActive(false);
                    slotNo4ButtonText.gameObject.SetActive(false);
                    slotNo5ButtonText.gameObject.SetActive(false);
                    slotNo6ButtonText.gameObject.SetActive(false);
                    slotNo7ButtonText.gameObject.SetActive(false);
                    slotNo8ButtonText.gameObject.SetActive(false);
                    slotNo9ButtonText.gameObject.SetActive(false);
                    slotNo10ButtonText.gameObject.SetActive(false);
                    slotNo11ButtonText.gameObject.SetActive(false);
                    slotNo12ButtonText.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }
          
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
                    no1 = true;
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
                    no2 = true;
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
                    no3 = true;
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
                    no4 = true;
                }

                if (no13InvProp.sphereHeld)
                {

                    sphereNo13.gameObject.SetActive(true);
                    no13InvProp.sphereButton.gameObject.SetActive(false);
                    no13InvProp.invItemImage.gameObject.SetActive(false);
                    no13InvProp.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    slotFilled = true;
                    incorrectSFX.Play();
                    no5 = true;
                }

                if (no16InvProp.sphereHeld)
                {

                    sphereNo16.gameObject.SetActive(true);
                    no16InvProp.sphereButton.gameObject.SetActive(false);
                    no16InvProp.invItemImage.gameObject.SetActive(false);
                    no16InvProp.sphereHeld = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    slotFilled = true;
                    correctSFX.Play();
                    no6 = true;
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
                    no7 = true;
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
                    no8 = true;
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
                    no9 = true;
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
                    no10 = true;
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
                    no11 = true;
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
                    no12 = true;
                }
            }
 
        }
    }
}

