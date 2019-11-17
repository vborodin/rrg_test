using UnityEngine;
using RRGTest.Physics;

namespace RRGTest {
    public class PlayerInput : MonoBehaviour {
        #pragma warning disable 0649
        [SerializeField]
        private Camera cam;
        #pragma warning restore 0649
        void Update() {
            if (Input.GetAxis("Cancel") != 0.0f) {
                AppContext.LoadMenuScene();
                return;
            }
            if (Input.GetMouseButtonDown(0)) {
                AppContext.forceMode = true;
            } else if (Input.GetMouseButtonUp(0)) {
                AppContext.forceMode = false;
            }

            if (AppContext.forceMode) {
                var pos = cam.ScreenToWorldPoint(Input.mousePosition);
                AppContext.forceTarget = new Vector2(pos.x, pos.y);
            }
        }
    }
}