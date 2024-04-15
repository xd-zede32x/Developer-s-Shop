using UnityEngine;

namespace OneLesson
{
    public class Character : MonoBehaviour, IControllable
    {
        public void Walk() => Debug.Log("Character: Walk");
        public void Run() => Debug.Log("Character: Run");

        public void Move() => Run();
    }
}