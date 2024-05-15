using System.Collections;
using UnityEngine;

namespace TensLessons
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] private float _lifeTime;

        private void OnEnable() => StartCoroutine(LifeRoutine());

        private void OnDisable() => StopCoroutine(LifeRoutine());

        private IEnumerator LifeRoutine()
        {
            yield return new WaitForSecondsRealtime(_lifeTime);

            Deactivate();
        }

        private void Deactivate() => gameObject.SetActive(false);
    }
}