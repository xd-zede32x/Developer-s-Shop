using UnityEngine;

namespace ScriptUIProgressBar
{
    public class UIWidgetLifeBar : MonoBehaviour
    {
        [SerializeField] private ProgressBar _progressBar;

        private void OnEnable()
        {
            var example = FindObjectOfType<Example>();

            _progressBar.SetValue(example.HealthNormalized);

            example.OnPlayerHealthValueChangeEvent += OnPlayerHealthValueChanged;
        }

        private void OnDisable()
        {
            var example = FindObjectOfType<Example>();

            if (example)
            {
                example.OnPlayerHealthValueChangeEvent -= OnPlayerHealthValueChanged;
            }
        }

        private void OnPlayerHealthValueChanged(float newValueNormalized)
        {
            _progressBar.SetValue(newValueNormalized);
        }
    }
}