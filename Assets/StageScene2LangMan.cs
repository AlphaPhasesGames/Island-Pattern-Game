using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class StageScene2LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stage2Scene2Text1;
        public TextMeshProUGUI stage2Scene2Text2;
        public TextMeshProUGUI stage2Scene2Text3;
        public TextMeshProUGUI stage2Scene2Text4;
        public TextMeshProUGUI stage2Scene2Text5;
        public TextMeshProUGUI stage2Scene2Text6;
        public TextMeshProUGUI stage2Scene2Text7;
        public TextMeshProUGUI stage2Scene2Text8;
        public TextMeshProUGUI stage2Scene2Text9;
        public TextMeshProUGUI stage2Scene2Text10;
        public TextMeshProUGUI stage2Scene2Text11;
        public TextMeshProUGUI stage2Scene2Text12;
        public TextMeshProUGUI stage2Scene2Text13;
        public TextMeshProUGUI stage2Scene2Text14;
        public TextMeshProUGUI stage2Scene2Text15;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeViewButton;
        public TextMeshProUGUI ruleButton;
        public TextMeshProUGUI resetButton;
        public TextMeshProUGUI triangle;
        public TextMeshProUGUI triangle2;
        public TextMeshProUGUI triangle3;
        public TextMeshProUGUI circle;
        public TextMeshProUGUI circle2;
        public TextMeshProUGUI circle3;
        public TextMeshProUGUI square;
        public TextMeshProUGUI square2;
        public TextMeshProUGUI square3;
        public TextMeshProUGUI hexagon1;
        public TextMeshProUGUI hexagon2;
        public TextMeshProUGUI hexagon3;
        public TextMeshProUGUI ruleTitle;
        public TextMeshProUGUI ruleItself;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            inventoryButton.text = defs["Inventory"];
            closeViewButton.text = defs["CloseView"];
            ruleButton.text = defs["RuleButton"];
            resetButton.text = defs["ResetButton"];
            triangle.text = defs["Stage2Scene1ShapeTriangle"];
            triangle2.text = defs["Stage2Scene1ShapeTriangle"];
            triangle3.text = defs["Stage2Scene1ShapeTriangle"];
            circle.text = defs["Stage2Scene1ShapeCircle"];
            circle2.text = defs["Stage2Scene1ShapeCircle"];
            circle3.text = defs["Stage2Scene1ShapeCircle"];
            square.text = defs["Stage2Scene1ShapeSquare"];
            square2.text = defs["Stage2Scene1ShapeSquare"];
            square3.text = defs["Stage2Scene1ShapeSquare"];
            hexagon1.text = defs["Stage2Scene1ShapeHexagon"];
            hexagon2.text = defs["Stage2Scene1ShapeHexagon"];
            hexagon3.text = defs["Stage2Scene1ShapeHexagon"];
            ruleItself.text = defs["Stage2Scene1RuleItself"];
            ruleTitle.text = defs["Stage1Scene1RuleTitle"];

            stage2Scene2Text1.text = defs["Stage2Scene2TextBox1"];
            stage2Scene2Text2.text = defs["Stage2Scene2TextBox2"];
            stage2Scene2Text3.text = defs["Stage2Scene2TextBox3"];
            stage2Scene2Text4.text = defs["Stage2Scene2TextBox4"];
            stage2Scene2Text5.text = defs["Stage2Scene2TextBox5"];
            stage2Scene2Text6.text = defs["Stage2Scene2TextBox6"];
            stage2Scene2Text7.text = defs["Stage2Scene2TextBox7"];
            stage2Scene2Text8.text = defs["Stage2Scene2TextBox8"];
            stage2Scene2Text9.text = defs["Stage2Scene2TextBox9"];
            stage2Scene2Text10.text = defs["Stage2Scene2TextBox10"];
            stage2Scene2Text11.text = defs["Stage2Scene2TextBox11"];
            stage2Scene2Text12.text = defs["Stage2Scene2TextBox12"];
            stage2Scene2Text13.text = defs["Stage2Scene2TextBox13"];
            stage2Scene2Text14.text = defs["Stage2Scene2TextBox14"];
            stage2Scene2Text15.text = defs["Stage2Scene2TextBox15"];
        }
    }
}