using UnityEngine;

namespace FourLessons
{
    public class SingletonTester : MonoBehaviour
    {
        private void Update() => UserInput();

        private void UserInput()
        {
            if (Input.GetKeyDown(KeyCode.G))
                GameManager.Instance.Debug();

            if (Input.GetKeyDown(KeyCode.B))
                Bank.Instance.Debug();
        }
    }
}