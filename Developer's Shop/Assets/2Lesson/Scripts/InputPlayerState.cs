using UnityEngine;

namespace TwoLesson
{
    public class InputPlayerState : MonoBehaviour
    {
        [SerializeField] PlayerState _player;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) 
                _player.setBehaviorAggressive();

            if (Input.GetKeyDown(KeyCode.I))
                _player.SetBehaviorIdle();

            if (Input.GetKeyDown(KeyCode.F))
                _player.SetBehaviorActive();
        }
    }
}