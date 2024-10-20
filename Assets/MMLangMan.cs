using UnityEngine;
using SimpleJSON;
using TMPro;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class MMLangMan : MonoBehaviour
    {
        public TextMeshProUGUI newGame;
        public TextMeshProUGUI continueGame;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            continueGame.text = defs["continue"];
            newGame.text = defs["newGame"];
        }
    }
}
