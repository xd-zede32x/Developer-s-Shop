using UnityEngine;
using UnityEngine.Events;

namespace ScriptUIProgressBar
{
    public class Example : MonoBehaviour
    {
        public event UnityAction<float> OnPlayerHealthValueChangeEvent;

        public int Health { get; private set; }
        public float HealthNormalized => (float)Health / _healthDefault;

        [SerializeField] private int _healthDefault = 100;
        [SerializeField] private int _damage;

        private void Awake()
        {
            Health = _healthDefault;
            OnPlayerHealthValueChangeEvent?.Invoke(HealthNormalized);
        }

        private void Update()
        => HitPlayer();

        private void DealingDamage()
        {
            Health -= _damage;

            if (Health <= 0)
            {
                Destroy(gameObject);
            }

            OnPlayerHealthValueChangeEvent?.Invoke(HealthNormalized);
        }

        private void HitPlayer()
        {
            if (Input.GetMouseButtonDown(0))
            {
                DealingDamage();
            }
        }
    }
}