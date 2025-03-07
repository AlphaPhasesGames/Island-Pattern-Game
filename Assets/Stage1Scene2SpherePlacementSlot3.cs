using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2SpherePlacementSlot3 : MonoBehaviour
    {
        public Stage1Scene2Number2InvProperties no2Prop;
        public Stage1Scene2Number3InvProperties no3Prop;
        public Stage1Scene2Number8InvProperties no8Prop;
        public Stage1Scene2Number10InvProperties no10Prop;
        public Stage1Scene2Number31InvProperties no31Prop;
        public Stage1Scene2Number32InvProperties no32Prop;

        public GameObject no2sphere;
        public GameObject no3sphere;
        public GameObject no8sphere;
        public GameObject no10sphere;
        public GameObject no31sphere;
        public GameObject no32sphere;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public AudioSource correctSFX;
        public AudioSource incorrectSFX;
        public bool slotFilled;
        // Start is called before the first frame update
        public GameObject sphere1Text;
        public GameObject sphere2Text;
        public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;

        public bool no1;
        public bool no2;
        public bool no3;
        public bool no4;
        public bool no5;
        public bool no6;
        public void OnMouseDown()
        {

            if (slotFilled && no1)
            {
                if (!no3Prop.sphereHeld && !no8Prop.sphereHeld && !no10Prop.sphereHeld && !no31Prop.sphereHeld && !no32Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no2sphere.gameObject.SetActive(false);
                    no2Prop.sphereButton.gameObject.SetActive(true);
                    no1 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }

            }

            else if (slotFilled && no2)
            {
                if (!no2Prop.sphereHeld && !no8Prop.sphereHeld && !no10Prop.sphereHeld && !no31Prop.sphereHeld && !no32Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no3sphere.gameObject.SetActive(false);
                    no3Prop.sphereButton.gameObject.SetActive(true);
                    no2 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }
            }

            else if (slotFilled && no3)
            {
                if (!no2Prop.sphereHeld && !no3Prop.sphereHeld && !no10Prop.sphereHeld && !no31Prop.sphereHeld && !no32Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no8sphere.gameObject.SetActive(false);
                    no8Prop.sphereButton.gameObject.SetActive(true);
                    no3 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }
            }

            else if (slotFilled && no4)
            {
                if (!no2Prop.sphereHeld && !no3Prop.sphereHeld && !no8Prop.sphereHeld && !no31Prop.sphereHeld && !no32Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no10sphere.gameObject.SetActive(false);
                    no10Prop.sphereButton.gameObject.SetActive(true);
                    no4 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }
            }

            else if (slotFilled && no5)
            {
                if (!no2Prop.sphereHeld && !no3Prop.sphereHeld && !no8Prop.sphereHeld && !no10Prop.sphereHeld && !no32Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no31sphere.gameObject.SetActive(false);
                    no31Prop.sphereButton.gameObject.SetActive(true);
                    no5 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }
            }

            else if (slotFilled && no6)
            {
                if (!no2Prop.sphereHeld && !no3Prop.sphereHeld && !no8Prop.sphereHeld && !no10Prop.sphereHeld && !no31Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    no32sphere.gameObject.SetActive(false);
                    no32Prop.sphereButton.gameObject.SetActive(true);
                    no6 = false;
                    slotFilled = false;
                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);
                    correctPlacement = false;
                    inCorrectPlacement = false;
                }
            }

            if (!slotFilled)
            {
                if (no2Prop.sphereHeld)
                {
                    no2sphere.gameObject.SetActive(true);
                    no2Prop.sphereButton.gameObject.SetActive(false);
                    no2Prop.invItemImage.gameObject.SetActive(false);
                    no2Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                    no1 = true;
                }

                if (no3Prop.sphereHeld)
                {
                    no3sphere.gameObject.SetActive(true);
                    no3Prop.sphereButton.gameObject.SetActive(false);
                    no3Prop.invItemImage.gameObject.SetActive(false);
                    no3Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                    no2 = true;
                }

                if (no8Prop.sphereHeld)
                {
                    no8sphere.gameObject.SetActive(true);
                    no8Prop.sphereButton.gameObject.SetActive(false);
                    no8Prop.invItemImage.gameObject.SetActive(false);
                    no8Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                    no3 = true;
                }

                if (no10Prop.sphereHeld)
                {
                    no10sphere.gameObject.SetActive(true);
                    no10Prop.sphereButton.gameObject.SetActive(false);
                    no10Prop.invItemImage.gameObject.SetActive(false);
                    no10Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                    no4 = true;
                }

                if (no31Prop.sphereHeld)
                {
                    no31sphere.gameObject.SetActive(true);
                    no31Prop.sphereButton.gameObject.SetActive(false);
                    no31Prop.invItemImage.gameObject.SetActive(false);
                    no31Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                    no5 = true;
                }

                if (no32Prop.sphereHeld)
                {
                    no32sphere.gameObject.SetActive(true);
                    no32Prop.sphereButton.gameObject.SetActive(false);
                    no32Prop.invItemImage.gameObject.SetActive(false);
                    no32Prop.sphereHeld = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    correctSFX.Play();
                    slotFilled = true;
                    no6 = true;
                }
            }

        }
    }
}
