using System;

namespace NineLessons
{
    public class Coin : Currency<int>
    {
        public override event Action<int> OnValueChangedEvent;

        public Coin() => value = 0;

        public override void Add(int amount)
        {
           
        }

        public override void Spend(int amount)
        {
            
        }
    }
}