using UnityEngine;

namespace TwoLesson
{
    public class PlayerBehaviorIdle : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter IDLE Behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit IDLE Behavior");
        }  

        public void Update()
        {
            Debug.Log("Update IDLE Behavior");
        } 
    }
}