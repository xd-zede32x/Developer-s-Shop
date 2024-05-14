using System;
using System.Numerics;

namespace NineLessons
{
    public class Dollar : Currency<BigInteger>
    {
        public override event Action<BigInteger> OnValueChangedEvent;

        public Dollar()
        {
            value = new BigInteger(0);
        }

        public override void Add(BigInteger amount)
        {
            
        }

        public override void Spend(BigInteger amount)
        {
           
        }
    }
}