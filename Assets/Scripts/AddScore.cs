using UnityEngine;

namespace RRGTest {
    public class AddScore : MonoBehaviour {
        void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.CompareTag("ball")) {
                AppContext.gameScore.IncreaseValue();
            }
        } 
    }
}