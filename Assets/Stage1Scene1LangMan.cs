using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class Stage1Scene1LangMan : MonoBehaviour
    {
        public TextMeshProUGUI unit17Text1;
        public TextMeshProUGUI unit17Text2;
        public TextMeshProUGUI unit17Text3;
        public TextMeshProUGUI unit17Text4;

        public TextMeshProUGUI pollyText5;
        public TextMeshProUGUI pollyText6;
        public TextMeshProUGUI pollyText7;
        public TextMeshProUGUI pollyText8;
        public TextMeshProUGUI pollyText9;
        public TextMeshProUGUI pollyText10;
        public TextMeshProUGUI pollyText11;
        public TextMeshProUGUI pollyText12;
        public TextMeshProUGUI pollyText13;
        public TextMeshProUGUI pollyText14;
        public TextMeshProUGUI pollyText15;
        public TextMeshProUGUI pollyText16;
        public TextMeshProUGUI pollyText17;
        public TextMeshProUGUI pollyText18;
        public TextMeshProUGUI pollyText19;
        public TextMeshProUGUI pollyText20;
        public TextMeshProUGUI pollyText21;
        public TextMeshProUGUI pollyText22;
        public TextMeshProUGUI pollyText23;
        public TextMeshProUGUI pollyText24;
        public TextMeshProUGUI pollyText25;

        public TextMeshProUGUI inventoryButton;
        public TextMeshProUGUI closeView;
        public TextMeshProUGUI ruleButton;
        public TextMeshProUGUI resetButton;
        public TextMeshProUGUI rulePanalTitle;
        public TextMeshProUGUI rulePanalRule;

        public TextMeshProUGUI number1Sphere;
        public TextMeshProUGUI number6Sphere;
        public TextMeshProUGUI number7Sphere;
        public TextMeshProUGUI number10Sphere;
        public TextMeshProUGUI number11Sphere;
        public TextMeshProUGUI number14Sphere;


        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            unit17Text1.text = defs["stage1Scene1TextBox1"];
            unit17Text2.text = defs["stage1Scene1TextBox2"];
            unit17Text3.text = defs["stage1Scene1TextBox3"];
            unit17Text4.text = defs["stage1Scene1TextBox4"];
            pollyText5.text = defs["stage1Scene1TextBox5"];
            pollyText6.text = defs["stage1Scene1TextBox6"];
            pollyText7.text = defs["stage1Scene1TextBox7"];
            pollyText8.text = defs["stage1Scene1TextBox8"];
            pollyText9.text = defs["stage1Scene1TextBox9"];
            pollyText10.text = defs["stage1Scene1TextBox10"];
            pollyText11.text = defs["stage1Scene1TextBox11"];
            pollyText12.text = defs["stage1Scene1TextBox12"];
            pollyText13.text = defs["stage1Scene1TextBox13"];
            pollyText14.text = defs["stage1Scene1TextBox14"];
            pollyText15.text = defs["stage1Scene1TextBox15"];
            pollyText16.text = defs["stage1Scene1TextBox16"];
            pollyText17.text = defs["stage1Scene1TextBox17"];
            pollyText18.text = defs["stage1Scene1TextBox18"];
            pollyText19.text = defs["stage1Scene1TextBox19"];
            pollyText20.text = defs["stage1Scene1TextBox20"];
            pollyText21.text = defs["stage1Scene1TextBox21"];
            pollyText22.text = defs["stage1Scene1TextBox22"];
            pollyText23.text = defs["stage1Scene1TextBox23"];
            pollyText24.text = defs["stage1Scene1TextBox24"];
            pollyText25.text = defs["stage1Scene1TextBox25"];
            inventoryButton.text = defs["inventory"];
            closeView.text = defs["closeView"];
            ruleButton.text = defs["ruleButton"];
            resetButton.text = defs["resetButton"];
            number1Sphere.text = defs["stage1Number1"];
            number6Sphere.text = defs["stage1Number6"];
            number7Sphere.text = defs["stage1Number7"];
            number10Sphere.text = defs["stage1Number10"];
            number11Sphere.text = defs["stage1Number11"];
            number14Sphere.text = defs["stage1Number14"];
            rulePanalTitle.text = defs["stage1Scene1RuleTitle"];
            rulePanalRule.text = defs["stage1Scene1RuleItself"];
        }
    }
}
