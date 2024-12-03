using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene1LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stage2Scene1Text1;
        public TextMeshProUGUI stage2Scene1Text2;
        public TextMeshProUGUI stage2Scene1Text3;
        public TextMeshProUGUI stage2Scene1Text4;
        public TextMeshProUGUI stage2Scene1Text5;
        public TextMeshProUGUI stage2Scene1Text6;
        public TextMeshProUGUI stage2Scene1Text7;
        public TextMeshProUGUI stage2Scene1Text8;
        public TextMeshProUGUI stage2Scene1Text9;
        public TextMeshProUGUI stage2Scene1Text10;
        public TextMeshProUGUI stage2Scene1Text11;
        public TextMeshProUGUI stage2Scene1Text12;
        public TextMeshProUGUI stage2Scene1Text13;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeViewButton;
        public TextMeshProUGUI ruleButton;
        public TextMeshProUGUI resetButton;
        public TextMeshProUGUI triangle;
        public TextMeshProUGUI triangle2;
        public TextMeshProUGUI triangle3;
        public TextMeshProUGUI circle;
        public TextMeshProUGUI circle2;
        public TextMeshProUGUI square;
        public TextMeshProUGUI ruleTitle;
        public TextMeshProUGUI ruleItself;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            inventoryButton.text = defs["inventory"];
            closeViewButton.text = defs["closeView"];
            ruleButton.text = defs["ruleButton"];
            resetButton.text = defs["resetButton"];
            triangle.text = defs["stage2Scene1ShapeTriangle"];
            triangle2.text = defs["stage2Scene1ShapeTriangle"];
            triangle3.text = defs["stage2Scene1ShapeTriangle"];
            circle.text = defs["stage2Scene1ShapeCircle"];
            circle2.text = defs["stage2Scene1ShapeCircle"];
            square.text = defs["stage2Scene1ShapeSquare"];
            ruleItself.text = defs["stage2Scene1RuleItself"];
            ruleTitle.text = defs["stage1Scene1RuleTitle"];

            stage2Scene1Text1.text = defs["stage2Scene1TextBox1"];
            stage2Scene1Text2.text = defs["stage2Scene1TextBox2"];
            stage2Scene1Text3.text = defs["stage2Scene1TextBox3"];
            stage2Scene1Text4.text = defs["stage2Scene1TextBox4"];
            stage2Scene1Text5.text = defs["stage2Scene1TextBox5"];
            stage2Scene1Text6.text = defs["stage2Scene1TextBox6"];
            stage2Scene1Text7.text = defs["stage2Scene1TextBox7"];
            stage2Scene1Text8.text = defs["stage2Scene1TextBox8"];
            stage2Scene1Text9.text = defs["stage2Scene1TextBox9"];
            stage2Scene1Text10.text = defs["stage2Scene1TextBox10"];
            stage2Scene1Text11.text = defs["stage2Scene1TextBox11"];
            stage2Scene1Text12.text = defs["stage2Scene1TextBox12"];
            stage2Scene1Text13.text = defs["stage2Scene1TextBox13"];
        }
    }
}
