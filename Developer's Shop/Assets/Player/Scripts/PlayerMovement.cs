using System;
using UnityEngine;

namespace ScriptsPlayer
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerMovement : MonoBehaviour, IMovement
    {
        [SerializeField, Range(1, 5)] private float _speed;

        private PlayerInput _playerInput;

        private void Start() => _playerInput = GetComponent<PlayerInput>();

        private void Update() => Move();

        public void Move()
        {
            Vector3 duration = new Vector3(_playerInput.Horizontal, 0f, _playerInput.Vertical);
            transform.Translate(duration * _speed * Time.deltaTime);
        }
    }
}