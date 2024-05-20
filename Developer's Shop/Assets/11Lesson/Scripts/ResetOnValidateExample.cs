using UnityEngine;
using UnityEngine.UI;

namespace ElevenLessons
{
    public class ResetOnValidateExample : MonoBehaviour
    {
        [SerializeField] private Image _progressBar;
        [SerializeField] private Transform _container;
        [SerializeField, Range(0f, 1f)] private float _value;

        private void Reset()
        {
            if (_container == null)
                _container = transform;

            if (_progressBar == null)
                _progressBar = GetComponent<Image>();
        }

        private void OnValidate() => _progressBar.fillAmount = _value;
    }
}