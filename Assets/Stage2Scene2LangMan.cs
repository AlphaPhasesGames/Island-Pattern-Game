using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage2Scene2LangMan : MonoBehaviour
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
        public TextMeshProUGUI stage2Scene2Text16;
        public TextMeshProUGUI stage2Scene2Text17;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeViewButton;
    //    public TextMeshProUGUI ruleButton;
        public TextMeshProUGUI resetButton;
        public TextMeshProUGUI square;
        public TextMeshProUGUI hexagon1;
        public TextMeshProUGUI diamond;
      //  public TextMeshProUGUI ruleTitle;
       // public TextMeshProUGUI ruleItself;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            inventoryButton.text = defs["inventory"];
            closeViewButton.text = defs["closeView"];
         //   ruleButton.text = defs["ruleButton"];
         //   resetButton.text = defs["resetButton"];
        
            square.text = defs["stage2Scene2ShapeGSquare"];
            hexagon1.text = defs["stage2Scene2ShapeGPentagon"];
            diamond.text = defs["stage2Scene2ShapeGDiamond"];

            stage2Scene2Text1.text = defs["stage2Scene2TextBox1"];
            stage2Scene2Text2.text = defs["stage2Scene2TextBox2"];
            stage2Scene2Text3.text = defs["stage2Scene2TextBox3"];
            stage2Scene2Text4.text = defs["stage2Scene2TextBox4"];
            stage2Scene2Text5.text = defs["stage2Scene2TextBox5"];
            stage2Scene2Text6.text = defs["stage2Scene2TextBox6"];
            stage2Scene2Text7.text = defs["stage2Scene2TextBox7"];
            stage2Scene2Text8.text = defs["stage2Scene2TextBox8"];
            stage2Scene2Text9.text = defs["stage2Scene2TextBox9"];
            stage2Scene2Text10.text = defs["stage2Scene2TextBox10"];
            stage2Scene2Text11.text = defs["stage2Scene2TextBox11"];
            stage2Scene2Text12.text = defs["stage2Scene2TextBox12"];
            stage2Scene2Text13.text = defs["stage2Scene2TextBox13"];
            stage2Scene2Text14.text = defs["stage2Scene2TextBox14"];
            stage2Scene2Text15.text = defs["stage2Scene2TextBox15"];
            stage2Scene2Text16.text = defs["stage2Scene2TextBox16"];
            stage2Scene2Text17.text = defs["stage2Scene2TextBox17"];

        }
    }
}