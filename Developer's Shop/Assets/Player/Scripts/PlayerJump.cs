using System.Collections;
using UnityEngine;

namespace ScriptsPlayer
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private AnimationCurve _yAnimation;
        [SerializeField] private AnimationCurve _scaleAnimation;


        [ContextMenu("Play Animation")]
        public void PlayAnimation(Transform jumper, float duration)
        {
            StartCoroutine(AnimationByTime(jumper, duration));
        }

        private IEnumerator AnimationByTime(Transform jumper, float duration)
        {
            var expiredSeconds = 0f;
            var progress = 0f;

            Vector3 startPosition = jumper.position;

            while (true)
            {
                expiredSeconds += Time.deltaTime;
                progress = expiredSeconds / duration;

                jumper.position = startPosition + new Vector3(0f, _yAnimation.Evaluate(progress), 0);
                jumper.localScale = Vector3.one * _scaleAnimation.Evaluate(progress);

                yield return null;
            }
        }
    }
}