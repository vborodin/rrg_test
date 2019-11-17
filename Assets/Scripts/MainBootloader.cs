using UnityEngine;

namespace RRGTest {
    public class MainBootloader : MonoBehaviour
    {
        private void Awake() {
            Debug.Log($"{AppContext.PlanetData.planetName}");
        }
    }
}