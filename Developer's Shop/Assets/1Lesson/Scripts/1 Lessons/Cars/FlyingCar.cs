using UnityEngine;

namespace OneLesson
{
    public class FlyingCar : BaseCar
    {
        private void Fly() => Debug.Log("FlyingCar is flying...");

        public override void Drive() => Fly();
    }
}