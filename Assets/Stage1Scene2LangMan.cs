using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene2LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stage1Scene2Text1;
        public TextMeshProUGUI stage1Scene2Text2;
        public TextMeshProUGUI stage1Scene2Text3;
        public TextMeshProUGUI stage1Scene2Text4;
        public TextMeshProUGUI stage1Scene2Text5;
        public TextMeshProUGUI stage1Scene2Text6;
        public TextMeshProUGUI stage1Scene2Text7;
        public TextMeshProUGUI stage1Scene2Text8;
        public TextMeshProUGUI stage1Scene2Text9;
        public TextMeshProUGUI stage1Scene2Text10;
        public TextMeshProUGUI stage1Scene2Text11;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeViewButton;
        public TextMeshProUGUI ruleButton;
        public TextMeshProUGUI ResetButton;
        public TextMeshProUGUI sphere2Text;
        public TextMeshProUGUI sphere3Text;
        public TextMeshProUGUI sphere8Text;
        public TextMeshProUGUI sphere10Text;
        public TextMeshProUGUI sphere31Text;
        public TextMeshProUGUI sphere32Text;
        public TextMeshProUGUI ruleTitle;
        public TextMeshProUGUI ruleItself;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            inventoryButton.text = defs["Inventory"];
            closeViewButton.text = defs["CloseView"];
            ruleButton.text = defs["RuleButton"];
            ResetButton.text = defs["ResetButton"];
            sphere2Text.text = defs["Stage2Number2"];
            sphere3Text.text = defs["Stage2Number3"];
            sphere8Text.text = defs["Stage2Number8"];
            sphere10Text.text = defs["Stage2Number10"];
            sphere31Text.text = defs["Stage2Number31"];
            sphere32Text.text = defs["Stage2Number32"];
            ruleItself.text = defs["Stage1Scene2RuleItself"];
            ruleTitle.text = defs["Stage1Scene1RuleTitle"];

            stage1Scene2Text1.text = defs["Stage1Scene2TextBox1"];
            stage1Scene2Text2.text = defs["Stage1Scene2TextBox2"];
            stage1Scene2Text3.text = defs["Stage1Scene2TextBox3"];
            stage1Scene2Text4.text = defs["Stage1Scene2TextBox4"];
            stage1Scene2Text5.text = defs["Stage1Scene2TextBox5"];
            stage1Scene2Text6.text = defs["Stage1Scene2TextBox6"];
            stage1Scene2Text7.text = defs["Stage1Scene2TextBox7"];
            stage1Scene2Text8.text = defs["Stage1Scene2TextBox8"];
            stage1Scene2Text9.text = defs["Stage1Scene2TextBox9"];
            stage1Scene2Text10.text = defs["Stage1Scene2TextBox10"];
            stage1Scene2Text11.text = defs["Stage1Scene2TextBox11"];
        }
    }
}
