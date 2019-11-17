using UnityEngine;

namespace RRGTest {
[RequireComponent(typeof(SpriteRenderer))]
    public class ChangeColorOnCollision : MonoBehaviour {
        private SpriteRenderer spriteRenderer;

        private void Awake() {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.CompareTag("ball")) {
                spriteRenderer.color = Random.ColorHSV();
            }
        } 
    }
}