using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptUIProgressBar
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Image _imageFiller;
        [SerializeField] private TextMeshProUGUI _textValue;

        public void SetValue(float valueNormalized)
        {
            _imageFiller.fillAmount = valueNormalized;

            var valueInPercent = Mathf.RoundToInt(valueNormalized * 100f);
            _textValue.text = $"{valueInPercent}%";
        }
    }
}