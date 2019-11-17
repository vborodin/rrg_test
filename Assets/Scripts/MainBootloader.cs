using UnityEngine;

namespace RRGTest {
    public class MainBootloader : MonoBehaviour
    {
        #pragma warning disable 0649
        [SerializeField]
        private Camera cam;
        [SerializeField]
        private GameObject ball;
        [SerializeField]
        private Transform spawnPosition;
        #pragma warning restore 0649

        private void Awake() {
            if (AppContext.PlanetData == null) {
                Debug.LogError("Planet data is not loaded!");
                return;
            }
            cam.backgroundColor = AppContext.PlanetData.planetColor;
            Physics2D.gravity = AppContext.PlanetData.gravity;
            Instantiate(ball, spawnPosition.position, Quaternion.identity);
            Debug.Log($"{AppContext.PlanetData.planetName}");
        }
    }
}