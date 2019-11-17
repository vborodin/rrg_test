using UnityEngine;

namespace RRGTest.Planets {
    [CreateAssetMenu(fileName = "NewPlanetData", menuName = "Planet Data")]
    public class PlanetData : ScriptableObject {
        [SerializeField]
        public string planetName = "Default";
        [SerializeField]
        public Color planetColor = Color.yellow;
        [SerializeField]
        public Vector2 gravity = new Vector2();
    }
}