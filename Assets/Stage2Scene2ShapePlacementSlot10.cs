using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2ShapePlacementSlot10 : MonoBehaviour
    {
        public Stage2Scene2Circle1InvItem circle1Prop;
        public Stage2Scene2Circle2InvItem circle2Prop;
        public StageScene2Circle3InvItem circle3Prop;

        public Stage2Scene2TriangleInventoryItem tri1Prop;
        public Stage2Scene2Triangle1InventoryItem tri2Prop;
        public Stage2Scene2Triangle3InvItem tri3Prop;

        public Stage2Scene2SquareInventoryItem squareProp;
        public StageScene2Square2InvItem square2Prop;
        public StageScene2Square3InvItem square3Prop;

        public Stage2Scene2Hexagon1InvItem hex1Prop;
        public Stage2Scene2Hexagon2InvItem hex2Prop;
        public Stage2Scene2Hexagon3InvItem hex3Prop;


        public GameObject circle;
        // public GameObject circle2;
        public GameObject triangle;
        public GameObject square;
        public GameObject hexagon;
        // public GameObject triangle2;
        // public GameObject triangle3;

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
                if (circle1Prop.circle1Held)
                {
                    circle.gameObject.SetActive(true);
                    circle1Prop.circle1Button.gameObject.SetActive(false);
                    circle1Prop.invItemImage.gameObject.SetActive(false);
                    circle1Prop.circle1Held = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    correctSFX.Play();
                    slotFilled = true;
                }

                if (circle2Prop.circle2Held)
                {

                    circle.gameObject.SetActive(true);
                    circle2Prop.circle2Button.gameObject.SetActive(false);
                    circle1Prop.invItemImage.gameObject.SetActive(false);
                    circle2Prop.circle2Held = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    correctSFX.Play();
                    slotFilled = true;

                }

                if (circle3Prop.circle3Held)
                {

                    circle.gameObject.SetActive(true);
                    circle3Prop.circle3Button.gameObject.SetActive(false);
                    circle3Prop.invItemImage.gameObject.SetActive(false);
                    circle3Prop.circle3Held = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    correctSFX.Play();
                    slotFilled = true;

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
                    slotFilled = true;

                }

                if (tri2Prop.sphereHeld)
                {
                    triangle.gameObject.SetActive(true);
                    tri2Prop.triangleButton.gameObject.SetActive(false);
                    tri2Prop.invItemImage.gameObject.SetActive(false);
                    tri2Prop.sphereHeld = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

                if (tri3Prop.triangle3Held)
                {
                    triangle.gameObject.SetActive(true);
                    tri3Prop.triangle3Button.gameObject.SetActive(false);
                    tri3Prop.invItemImage.gameObject.SetActive(false);
                    tri3Prop.triangle3Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

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
                    slotFilled = true;

                }

                if (square2Prop.square2Held)
                {
                    square.gameObject.SetActive(true);
                    square2Prop.square2Button.gameObject.SetActive(false);
                    square2Prop.invItemImage.gameObject.SetActive(false);
                    square2Prop.square2Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

                if (square3Prop.square3Held)
                {
                    square.gameObject.SetActive(true);
                    square3Prop.square3Button.gameObject.SetActive(false);
                    square3Prop.invItemImage.gameObject.SetActive(false);
                    square3Prop.square3Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

                if (hex1Prop.hexagon1Held)
                {
                    hexagon.gameObject.SetActive(true);
                    hex1Prop.hexagon1Button.gameObject.SetActive(false);
                    hex1Prop.invItemImage.gameObject.SetActive(false);
                    hex1Prop.hexagon1Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

                if (hex2Prop.hexagon2Held)
                {
                    hexagon.gameObject.SetActive(true);
                    hex2Prop.hexagon2Button.gameObject.SetActive(false);
                    hex2Prop.invItemImage.gameObject.SetActive(false);
                    hex2Prop.hexagon2Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

                if (hex3Prop.hexagon3Held)
                {
                    hexagon.gameObject.SetActive(true);
                    hex3Prop.hexagon3Button.gameObject.SetActive(false);
                    hex3Prop.invItemImage.gameObject.SetActive(false);
                    hex3Prop.hexagon3Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }
            }

        }
    }
}

