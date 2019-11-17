using UnityEngine;

namespace RRGTest.Physics {
    [RequireComponent(typeof(Rigidbody2D))]
    public class AddForce : MonoBehaviour
    {
        private Rigidbody2D rb;

        private void Awake() {
            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate() {
            if (AppContext.forceMode) {
                rb.AddForce(AppContext.forceTarget - rb.position);
            }
        }
    }
}