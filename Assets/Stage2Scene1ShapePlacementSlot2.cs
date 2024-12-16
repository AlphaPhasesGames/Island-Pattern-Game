using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1ShapePlacementSlot2 : MonoBehaviour
    {
        public Stage2Scene1CircleInventoryItem circle1Prop;
        public Stage2Scene1Circle2InventoryItem circle2Prop;
        public Stage2Scene1Triangle1InventoryItem tri1Prop;
        public Stage2Scene1SquareInventoryItem squareProp;
        public Stage2Scene1Triangle2 tri2Prop;
        public Stage2Scene1Triangle3InventoryItem tri3Prop;

        public GameObject circle;
        // public GameObject circle2;
        public GameObject triangle;
        public GameObject square;
        // public GameObject triangle2;
        // public GameObject triangle3;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public AudioSource correctSFX;
        public AudioSource incorrectSFX;
        // Start is called before the first frame update

        public void OnMouseDown()
        {
            if (circle1Prop.sphereHeld)
            {
                circle.gameObject.SetActive(true);
                circle1Prop.circle1Button.gameObject.SetActive(false);
                circle1Prop.invItemImage.gameObject.SetActive(false);
                circle1Prop.sphereHeld = false;
                correctPlacement = true;
                inCorrectPlacement = false;
                correctSFX.Play();

            }

            if (circle2Prop.sphereHeld)
            {

                circle.gameObject.SetActive(true);
                circle2Prop.circle2Button.gameObject.SetActive(false);
                circle1Prop.invItemImage.gameObject.SetActive(false);
                circle2Prop.sphereHeld = false;
                correctPlacement = true;
                inCorrectPlacement = false;
                correctSFX.Play();


            }

            if (tri1Prop.sphereHeld)
            {
                triangle.gameObject.SetActive(true);
                tri1Prop.triangleButton.gameObject.SetActive(false);
                tri1Prop.invItemImage.gameObject.SetActive(false);
                tri1Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
                incorrectSFX.Play();

            }

            if (squareProp.sphereHeld)
            {
                square.gameObject.SetActive(true);
                squareProp.squareButton.gameObject.SetActive(false);
                squareProp.invItemImage.gameObject.SetActive(false);
                squareProp.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
                incorrectSFX.Play();

            }

            if (tri2Prop.sphereHeld)
            {
                triangle.gameObject.SetActive(true);
                tri2Prop.triangle2Button.gameObject.SetActive(false);
                tri2Prop.invItemImage.gameObject.SetActive(false);
                tri2Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
                incorrectSFX.Play();

            }

            if (tri3Prop.sphereHeld)
            {
                triangle.gameObject.SetActive(true);
                tri3Prop.triangle3Button.gameObject.SetActive(false);
                tri3Prop.invItemImage.gameObject.SetActive(false);
                tri3Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
                incorrectSFX.Play();

            }
        }
    }
}
