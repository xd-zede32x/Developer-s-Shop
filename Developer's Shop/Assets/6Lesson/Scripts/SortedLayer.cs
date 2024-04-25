using UnityEngine;

namespace SixLessons
{
    public class SortedLayer : MonoBehaviour
    {
        [SerializeField] private Transform _popupShop;
        [SerializeField] private Transform _popupInventory;

        private void Update() => UserInput();

        private void UserInput()
        {
            if (Input.GetKeyDown(KeyCode.I))
                ShowPopup(_popupInventory);

            if (Input.GetKeyDown(KeyCode.S))
                ShowPopup(_popupShop);
        }

        private void ShowPopup(Transform popup)
        {
            popup.gameObject.SetActive(true);
            popup.SetAsLastSibling();
        }
    }
}