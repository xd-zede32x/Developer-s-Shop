using System;
using UnityEngine;

namespace OneLesson
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] GameObject _gameObject;

        private IControllable _controllableObject;

        private void Start()
        {
            _controllableObject = _gameObject.GetComponent<IControllable>();

            if (_controllableObject == null)
                throw new NullReferenceException("GameObject dons not have IControllable interface.");
        }

        private void Update() => UserInput(KeyCode.Space);

        private void UserInput(KeyCode key)
        {
            if (Input.GetKeyDown(key))
                _controllableObject.Move();
        }
    }
}