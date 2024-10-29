using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1SpherePlacementSlot1 : MonoBehaviour
    {

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

        public bool correctPlacement;
        public bool inCorrectPlacement;

        // Start is called before the first frame update

        public void OnMouseDown()
        {
            if (no1Prop.sphereHeld)
            {
                no1sphere.gameObject.SetActive(true);
                no1Prop.sphereButton.gameObject.SetActive(false);
                no1Prop.invItemImage.gameObject.SetActive(false);
                no1Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
            }

            if (no6Prop.sphereHeld)
            {
                no6sphere.gameObject.SetActive(true);
                no6Prop.sphereButton.gameObject.SetActive(false);
                no6Prop.invItemImage.gameObject.SetActive(false);
                no6Prop.sphereHeld = false;
                correctPlacement = true;

            }

            if (no7Prop.sphereHeld)
            {
                no7sphere.gameObject.SetActive(true);
                no7Prop.sphereButton.gameObject.SetActive(false);
                no7Prop.invItemImage.gameObject.SetActive(false);
                no7Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;

            }

            if (no10Prop.sphereHeld)
            {
                no10sphere.gameObject.SetActive(true);
                no10Prop.sphereButton.gameObject.SetActive(false);
                no10Prop.invItemImage.gameObject.SetActive(false);
                no10Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;

            }

            if (no11Prop.sphereHeld)
            {
                no11sphere.gameObject.SetActive(true);
                no11Prop.sphereButton.gameObject.SetActive(false);
                no11Prop.invItemImage.gameObject.SetActive(false);
                no11Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;

            }

            if (no14Prop.sphereHeld)
            {
                no14sphere.gameObject.SetActive(true);
                no14Prop.sphereButton.gameObject.SetActive(false);
                no14Prop.invItemImage.gameObject.SetActive(false);
                no14Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;

            }
        }
    }
}
