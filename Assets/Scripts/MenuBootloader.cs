using UnityEngine;
using UnityEngine.UI;
using RRGTest.Planets;

namespace RRGTest {
    public class MenuBootloader : MonoBehaviour {
        #pragma warning disable 0649
        [SerializeField]
        private GameObject buttonPrefab;
        [SerializeField]
        private Transform contentHolder;
        #pragma warning restore 0649

        private void Start() {
            var planets = Resources.LoadAll("PlanetData", typeof(PlanetData));
            foreach (PlanetData p in planets) {
                var b = Instantiate(buttonPrefab);
                b.name = $"{p.planetName}Button";
                b.transform.SetParent(contentHolder, false);
                b.GetComponentInChildren<Text>().text = p.planetName;
            }
        }
    }
}
