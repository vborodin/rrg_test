using UnityEngine;
using UnityEngine.UI;

namespace RRGTest.UI {
    [RequireComponent(typeof(Text))]
    public class ScoreText : MonoBehaviour
    {
        private void Start() {
            var text = GetComponent<Text>();
            text.text = $"{AppContext.gameScore.Value}";
        }
    }
}