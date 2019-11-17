using RRGTest.Planets;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace RRGTest {
    public static class AppContext {
        public static PlanetData PlanetData { get; private set; }
        public static bool forceMode = false;
        public static Vector2 forceTarget;
        public static GameScore gameScore;
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