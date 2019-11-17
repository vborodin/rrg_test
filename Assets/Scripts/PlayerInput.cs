using UnityEngine;

namespace RRGTest {
    public class PlayerInput : MonoBehaviour {
        void FixedUpdate() {
            if (Input.GetAxis("Cancel") != 0.0f) {
                AppContext.LoadMenuScene();
                return;
            }
        }
    }
}