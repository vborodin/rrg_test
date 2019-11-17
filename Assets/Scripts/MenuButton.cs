using UnityEngine;
using UnityEngine.EventSystems;
using RRGTest.Planets;

namespace RRGTest.UI {
    public class MenuButton : MonoBehaviour, IPointerClickHandler
    {
        public PlanetData planetData;
        public void OnPointerClick(PointerEventData eventData)
        {
            AppContext.LoadMainScene(planetData);
        }
    }
}