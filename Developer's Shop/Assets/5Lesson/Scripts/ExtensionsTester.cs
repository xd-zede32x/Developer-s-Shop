using UnityEngine;
using UnityEngine.UI;

namespace FiveLessons
{
    public class ExtensionsTester : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Transform _transform;

        private bool _isActiveTransform;

        private void OnEnable() => _button.AddListener(OnClick);

        private void OnDisable() => _button.AddListener(OnClick);

        private void Update() => UserInput();

        public void OnClick() => Debug.Log("On Button Clicked");

        private void UserInput()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (_transform != null)
                {
                    if (!_isActiveTransform)
                    {
                        _transform.Deactivate();
                        _isActiveTransform = true;
                    }

                    else if (_isActiveTransform)
                    {
                        _transform.Activate();
                        _isActiveTransform = false;
                    }
                }
            }

            else if (Input.GetKeyDown(KeyCode.Space))
                _transform.Destroy();
        }
    }
}