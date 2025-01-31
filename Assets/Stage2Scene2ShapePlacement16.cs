using UnityEngine;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2ShapePlacement16 : MonoBehaviour
    {
        public Stage2Scene2SquareInventoryItem squareProp;
        public Stage2Scene2Hexagon1InvItem hex1Prop;
        public Stage2Scene2DiamondInvItem diamondProp;


        public GameObject square;
        public GameObject hexagon;
        public GameObject diamond;

        public bool correctPlacement;
        public bool inCorrectPlacement;

        public AudioSource correctSFX;
        public AudioSource incorrectSFX;
        public GameObject shape1Text;
        public GameObject shape2Text;
        public GameObject shape3Text;
        public bool slotFilled;
        // Start is called before the first frame update

        public void OnMouseDown()
        {

            if (slotFilled)
            {

                Debug.Log("This slot is now empty");

                correctPlacement = false;
                slotFilled = false;
                hexagon.gameObject.SetActive(false);
                square.gameObject.SetActive(false);
                diamond.gameObject.SetActive(false);
                inCorrectPlacement = false;
                incorrectSFX.Play();

                shape1Text.gameObject.SetActive(false);
                shape2Text.gameObject.SetActive(false);
                shape3Text.gameObject.SetActive(false);

            }

            if (!slotFilled)
            {
                if (hex1Prop.hexagon1Held)
                {
                    hexagon.gameObject.SetActive(true);
                    //  hex1Prop.hexagon1Button.gameObject.SetActive(false);
                    hex1Prop.invItemImage.gameObject.SetActive(false);
                    hex1Prop.hexagon1Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;
                }

                if (squareProp.sphereHeld)
                {

                    square.gameObject.SetActive(true);
                    //  squareProp.squareButton.gameObject.SetActive(false);
                    squareProp.invItemImage.gameObject.SetActive(false);
                    squareProp.sphereHeld = false;
                    correctPlacement = true;
                    inCorrectPlacement = false;
                    correctSFX.Play();
                    slotFilled = true;

                }

                if (diamondProp.diamond1Held)
                {

                    diamond.gameObject.SetActive(true);
                    //  diamondProp.diamond1Button.gameObject.SetActive(false);
                    diamondProp.invItemImage.gameObject.SetActive(false);
                    diamondProp.diamond1Held = false;
                    correctPlacement = false;
                    inCorrectPlacement = true;
                    incorrectSFX.Play();
                    slotFilled = true;

                }

            }

        }
    }
}
