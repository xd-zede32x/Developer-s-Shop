using UnityEngine;

namespace OneLesson
{
    public abstract class BaseCar : MonoBehaviour, IControllable
    {
        public virtual void Drive() => Debug.Log("Car is driving...");

        public void Move() => Drive();
    }
}