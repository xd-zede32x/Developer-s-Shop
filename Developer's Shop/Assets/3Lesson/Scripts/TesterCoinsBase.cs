using UnityEngine;

namespace ThreeLesson
{
    public class TesterCoinsBase : MonoBehaviour
    {
        private int _coinsMin = 5;
        private int _coinsMax = 100;

        private Bank _bank;

        public TesterCoinsBase(Bank bank)
        {
            _bank = bank;
        }

        public void TestAddCoinsToBank() 
        {
            var randomCoins = Random.Range(_coinsMin, _coinsMax);
            _bank.AddCoins(this, randomCoins);
        }
    }
}