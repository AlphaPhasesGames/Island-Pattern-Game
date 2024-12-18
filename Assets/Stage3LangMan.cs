using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage3LangMan : MonoBehaviour
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
        public TextMeshProUGUI stage2Scene2Text18;
        public TextMeshProUGUI stage2Scene2Text19;
        public TextMeshProUGUI stage2Scene2Text20;
        public TextMeshProUGUI stage2Scene2Text21;
        public TextMeshProUGUI stage2Scene2Text22;
        public TextMeshProUGUI stage2Scene2Text23;
        public TextMeshProUGUI stage2Scene2Text24;
        public TextMeshProUGUI stage2Scene2Text25;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeViewButton;
        public TextMeshProUGUI resetButton;

        public TextMeshProUGUI sphere1Text;
        public TextMeshProUGUI sphere4Text;
        public TextMeshProUGUI sphere7Text;
        public TextMeshProUGUI sphere10Text;
        public TextMeshProUGUI sphere13Text;
        public TextMeshProUGUI sphere16Text;
        public TextMeshProUGUI sphere19Text;
        public TextMeshProUGUI sphere22Text;
        public TextMeshProUGUI sphere25Text;
        public TextMeshProUGUI sphere28Text;
        public TextMeshProUGUI sphere31Text;
        public TextMeshProUGUI sphere34Text;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            inventoryButton.text = defs["inventory"];
            closeViewButton.text = defs["closeView"];
            resetButton.text = defs["resetButton"];

            stage2Scene2Text1.text = defs["stage3Scene1TextBox1"];
            stage2Scene2Text2.text = defs["stage3Scene1TextBox2"];
            stage2Scene2Text3.text = defs["stage3Scene1TextBox3"];
            stage2Scene2Text4.text = defs["stage3Scene1TextBox4"];
            stage2Scene2Text5.text = defs["stage3Scene1TextBox5"];
            stage2Scene2Text6.text = defs["stage3Scene1TextBox6"];
            stage2Scene2Text7.text = defs["stage3Scene1TextBox7"];
            stage2Scene2Text8.text = defs["stage3Scene1TextBox8"];
            stage2Scene2Text9.text = defs["stage3Scene1TextBox9"];
            stage2Scene2Text10.text = defs["stage3Scene1TextBox10"];
            stage2Scene2Text11.text = defs["stage3Scene1TextBox11"];
            stage2Scene2Text12.text = defs["stage3Scene1TextBox12"];
            stage2Scene2Text13.text = defs["stage3Scene1TextBox13"];
            stage2Scene2Text14.text = defs["stage3Scene1TextBox14"];
            stage2Scene2Text15.text = defs["stage3Scene1TextBox15"];
            stage2Scene2Text16.text = defs["stage3Scene1TextBox16"];
            stage2Scene2Text17.text = defs["stage3Scene1TextBox17"];
            stage2Scene2Text18.text = defs["stage3Scene1TextBox18"];
            stage2Scene2Text19.text = defs["stage3Scene1TextBox19"];
            stage2Scene2Text20.text = defs["stage3Scene1TextBox20"];
            stage2Scene2Text21.text = defs["stage3Scene1TextBox21"];
            stage2Scene2Text22.text = defs["stage3Scene1TextBox22"];
            stage2Scene2Text23.text = defs["stage3Scene1TextBox23"];
            stage2Scene2Text24.text = defs["stage3Scene1TextBox24"];
            stage2Scene2Text25.text = defs["stage3Scene1TextBox25"];

            sphere1Text.text = defs["stage3Number1"];
            sphere4Text.text = defs["stage3Number4"];
            sphere7Text.text = defs["stage3Number7"];
            sphere10Text.text = defs["stage2Number10"];
            sphere13Text.text = defs["stage3Number13"];
            sphere16Text.text = defs["stage3Number16"];
            sphere19Text.text = defs["stage3Number19"];
            sphere22Text.text = defs["stage3Number22"];
            sphere25Text.text = defs["stage3Number25"];
            sphere28Text.text = defs["stage3Number28"];
            sphere31Text.text = defs["stage3Number31"];
            sphere34Text.text = defs["stage2Number34"];

        }
    }
}
