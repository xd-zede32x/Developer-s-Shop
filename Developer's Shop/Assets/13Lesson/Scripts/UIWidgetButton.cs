using UnityEngine;
using System.Collections;

namespace ButtonScripts
{
    public class UIWidgetButton : MonoBehaviour
    {
        [SerializeField] private UIWidgetButtonAnimator _buttonAnimator;
        [SerializeField] private float _lifeTime = 3f;

        private void Awake()
        => _buttonAnimator.OnAppearAnimationOverEvent += OnAppearAnimationOver;

        private void OnDestroy()
        => _buttonAnimator.OnAppearAnimationOverEvent -= OnAppearAnimationOver;

        private void OnAppearAnimationOver()
        => StartCoroutine(LifeTimeButton());

        private IEnumerator LifeTimeButton()
        {
            yield return new WaitForSeconds(_lifeTime);

            _buttonAnimator.PlayHide();
        }
    }
}