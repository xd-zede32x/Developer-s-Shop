using UnityEngine;

namespace TwoLesson
{
    public class PlayerBehaviorAggressive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter AGGRESSIVE Behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit AGGRESSIVE Behavior");
        }

        public void Update()
        {
            Debug.Log("Update AGGRESSIVE Behavior");
        }
    }
}