using UnityEngine;
using UnityEngine.Events;

namespace ThreeLesson
{
    public class Bank : MonoBehaviour
    {
        public delegate void BankHandler(object sender, int oldCoinsValue, int newCoinsValue);
        public event BankHandler OnCoinsValueChangedEvent;

        public event UnityAction<object, int , int> OnCoinsValueChangedActionEvent;

        public int Coins { get; private set; }

        public void AddCoins(object sender, int amount)
        {
            var oldCoinsValue = Coins;

            Coins += amount;

            OnCoinsValueChangedEvent?.Invoke(sender, oldCoinsValue, Coins);
            OnCoinsValueChangedActionEvent?.Invoke(sender, oldCoinsValue, Coins);
        }

        public void SpendCoins(object sender, int amount)
        {
            var oldCoinsValue = Coins;

            Coins -= amount;

            OnCoinsValueChangedEvent?.Invoke(sender, oldCoinsValue, Coins);
            OnCoinsValueChangedActionEvent?.Invoke(sender, oldCoinsValue, Coins);
        }

        public bool IsEnoughCoins(int amount) => amount <= Coins;
    }
}