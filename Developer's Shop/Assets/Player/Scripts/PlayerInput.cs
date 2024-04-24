using UnityEngine;

namespace ScriptsPlayer
{
    public class PlayerInput : MonoBehaviour
    {
        private readonly string HORIZONTAL_STRING = "Horizontal";
        private readonly string VERTICAL_STRING = "Vertical";

        public float Horizontal => _horizontal;
        public float Vertical => _vertical;

        private float _horizontal;
        private float _vertical;

        private void Update() => UserInputPlayer();

        private void UserInputPlayer()
        {
            _horizontal = Input.GetAxis(HORIZONTAL_STRING);
            _vertical = Input.GetAxis(VERTICAL_STRING);
        }
    }
}