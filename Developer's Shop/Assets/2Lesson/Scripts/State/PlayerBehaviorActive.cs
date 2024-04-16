using UnityEngine;

namespace TwoLesson
{
    public class PlayerBehaviorActive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter ACTIVE Behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit ACTIVE Behavior");
        }

        public void Update()
        {
            Debug.Log("Update ACTIVE Behavior");
        }
    }
}