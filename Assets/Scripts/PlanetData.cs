using UnityEngine;

namespace RRGTest.Planets {
    [CreateAssetMenu(fileName = "NewPlanetData", menuName = "Planet Data")]
    public class PlanetData : ScriptableObject {
        [SerializeField]
        public string planetName = "Default";
    }
}