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

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            unit17Text1.text = defs["Stage1Scene1TextBox1"];
            unit17Text2.text = defs["Stage1Scene1TextBox2"];
            unit17Text3.text = defs["Stage1Scene1TextBox3"];
            unit17Text4.text = defs["Stage1Scene1TextBox4"];
            pollyText5.text = defs["Stage1Scene1TextBox5"];
            pollyText6.text = defs["Stage1Scene1TextBox6"];
            pollyText7.text = defs["Stage1Scene1TextBox7"];
            pollyText8.text = defs["Stage1Scene1TextBox8"];
            pollyText9.text = defs["Stage1Scene1TextBox9"];
        }
    }
}
