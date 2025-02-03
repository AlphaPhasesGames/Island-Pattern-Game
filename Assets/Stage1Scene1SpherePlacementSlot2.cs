using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1SpherePlacementSlot2 : MonoBehaviour
    {
       // public InventoryStage1Scene1 inv;

        public Stage1Scene1Number4InvProperties no1Prop;
        public Stage1Scene1Number6InvProperties no6Prop;
        public Stage1Scene1Number7InvProperties no7Prop;
        public Stage1Scene1Number10InvProperties no10Prop;
        public Stage1Scene1Number11InvProperties no11Prop;
        public Stage1Scene1Number14InvProperties no14Prop;

        public GameObject no1sphere;
        public GameObject no6sphere;
        public GameObject no7sphere;
        public GameObject no10sphere;
        public GameObject no11sphere;
        public GameObject no14sphere;

        public AudioSource correctSFX;
        public AudioSource incorrectSFX;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public bool slotFilled;


        public GameObject sphere1Text;
        public GameObject sphere2Text;
        public GameObject sphere3Text;
        public GameObject sphere4Text;
        public GameObject sphere5Text;
        public GameObject sphere6Text;
        // Start is called before the first frame update

        public void OnMouseDown()
        {

            if (slotFilled)
            {

                if (!no1Prop.sphereHeld && !no6Prop.sphereHeld && !no7Prop.sphereHeld && !no10Prop.sphereHeld && !no11Prop.sphereHeld && !no14Prop.sphereHeld) //|| !no2 || !no3 || !no4 || !no5 || !no6)
                {
                    Debug.Log("This slot is now empty");

                    correctPlacement = false;
                    slotFilled = false;
                    no1sphere.gameObject.SetActive(false);
                    no6sphere.gameObject.SetActive(false);
                    no7sphere.gameObject.SetActive(false);
                    no10sphere.gameObject.SetActive(false);
                    no11sphere.gameObject.SetActive(false);
                    no14sphere.gameObject.SetActive(false);

                    no1Prop.sphereButton.gameObject.SetActive(true);
                    no6Prop.sphereButton.gameObject.SetActive(true);
                    no7Prop.sphereButton.gameObject.SetActive(true);
                    no10Prop.sphereButton.gameObject.SetActive(true);
                    no11Prop.sphereButton.gameObject.SetActive(true);
                    no14Prop.sphereButton.gameObject.SetActive(true);
                    inCorrectPlacement = false;
                    incorrectSFX.Play();

                    sphere1Text.gameObject.SetActive(false);
                    sphere2Text.gameObject.SetActive(false);
                    sphere3Text.gameObject.SetActive(false);
                    sphere4Text.gameObject.SetActive(false);
                    sphere5Text.gameObject.SetActive(false);
                    sphere6Text.gameObject.SetActive(false);

                    //   slotFilled = false;

                }

            }
            if (!slotFilled)
            {

                if (no1Prop.sphereHeld)
                {
                    no1sphere.gameObject.SetActive(true);
                    no1Prop.sphereButton.gameObject.SetActive(false);
                    no1Prop.invItemImage.gameObject.SetActive(false);
                    no1Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }

                if (no6Prop.sphereHeld)
                {
                    no6sphere.gameObject.SetActive(true);
                    no6Prop.sphereButton.gameObject.SetActive(false);
                    no6Prop.invItemImage.gameObject.SetActive(false);
                    no6Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }

                if (no7Prop.sphereHeld)
                {
                    no7sphere.gameObject.SetActive(true);
                    no7Prop.sphereButton.gameObject.SetActive(false);
                    no7Prop.invItemImage.gameObject.SetActive(false);
                    no7Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }

                if (no10Prop.sphereHeld)
                {
                    no10sphere.gameObject.SetActive(true);
                    no10Prop.sphereButton.gameObject.SetActive(false);
                    no10Prop.invItemImage.gameObject.SetActive(false);
                    no10Prop.sphereHeld = false;
                    correctPlacement = true;
                    correctSFX.Play();
                    slotFilled = true;
                }

                if (no11Prop.sphereHeld)
                {
                    no11sphere.gameObject.SetActive(true);
                    no11Prop.sphereButton.gameObject.SetActive(false);
                    no11Prop.invItemImage.gameObject.SetActive(false);
                    no11Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }

                if (no14Prop.sphereHeld)
                {
                    no14sphere.gameObject.SetActive(true);
                    no14Prop.sphereButton.gameObject.SetActive(false);
                    no14Prop.invItemImage.gameObject.SetActive(false);
                    no14Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }
            }
        }
    }
}
