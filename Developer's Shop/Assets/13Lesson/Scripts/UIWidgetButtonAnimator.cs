using UnityEngine;
using UnityEngine.Events;

namespace ButtonScripts
{
    public class UIWidgetButtonAnimator : MonoBehaviour
    {
        private const string Hide = nameof(Hide);

        public event UnityAction OnAppearAnimationOverEvent;

        [SerializeField] private Animator _animator;

        private void OnValidate()
        => _animator = GetComponent<Animator>();

        private void Start()
        => _animator ??= GetComponent<Animator>();

        public void PlayHide()
        => _animator.SetTrigger(Hide);

        private void HandleAppearAnimationOver()
        => OnAppearAnimationOverEvent?.Invoke();
    }
}