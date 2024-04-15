using UnityEngine;

namespace OneLesson
{
    public class BrokenCar : BaseCar
    {
        public override void Drive()
        {
            base.Drive();

            Debug.Log("Very slow...");
        }
    }
}