using UnityEngine;

namespace RRGTest {
[CreateAssetMenu(fileName = "NewGameScore", menuName = "Game Score")]
    public class GameScore : ScriptableObject
    {
        public int Value { get; private set; } = 0;
        public void IncreaseValue() {
            Value++;
        }
    }
}