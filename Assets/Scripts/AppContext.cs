using RRGTest.Planets;
using UnityEngine.SceneManagement;

namespace RRGTest {
    public static class AppContext {
        public static PlanetData PlanetData { get; private set; }
        public static void LoadMainScene(PlanetData pd) {
            PlanetData = pd;
            SceneManager.LoadScene("Main");
        }
        public static void LoadMenuScene() {
            PlanetData = null;
            SceneManager.LoadScene("Menu");
        }
    }
}