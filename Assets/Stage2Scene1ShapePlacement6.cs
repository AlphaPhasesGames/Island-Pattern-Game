using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1ShapePlacement6 : MonoBehaviour
    {
        //  public Stage2Scene1CircleInventoryItem circle1Prop;
        // public Stage2Scene1Circle2InventoryItem circle2Prop;
        public Stage2Scene1Triangle1InventoryItem tri1Prop;
        //  public Stage2Scene1SquareInventoryItem squareProp;
        public Stage2Scene1Triangle2 tri2Prop;
        //  public Stage2Scene1Triangle3InventoryItem tri3Prop;

        public GameObject tri1blueTriangle;
        // public GameObject circle2;
        public GameObject tri2greenTriangle;
        //  public GameObject square;
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

            if (tri1Prop.sphereHeld)
            {
                tri1blueTriangle.gameObject.SetActive(true);
                //    tri1Prop.triangleButton.gameObject.SetActive(false);
                tri1Prop.invItemImage.gameObject.SetActive(false);
                tri1Prop.sphereHeld = false;
                correctPlacement = true;
                inCorrectPlacement = false;
                correctSFX.Play();
                slotFilled = true;

            }

            if (tri2Prop.sphereHeld)
            {
                tri2greenTriangle.gameObject.SetActive(true);
                //     tri2Prop.triangle2Button.gameObject.SetActive(false);
                    tri2Prop.invItemImage.gameObject.SetActive(false);
                tri2Prop.sphereHeld = false;
                correctPlacement = false;
                inCorrectPlacement = true;
                incorrectSFX.Play();
                slotFilled = true;

            }

        }
    }

}

