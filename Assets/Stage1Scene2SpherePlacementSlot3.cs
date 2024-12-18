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

        public void OnMouseDown()
        {
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

                }
            }

        }
    }
}
