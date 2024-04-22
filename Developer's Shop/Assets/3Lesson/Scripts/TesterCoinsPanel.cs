using UnityEngine;

namespace ThreeLesson
{
    public class TesterCoinsPanel : MonoBehaviour
    {
        private Bank _bank;

        public TesterCoinsPanel(Bank bank)
        {
            _bank = bank;

            _bank.OnCoinsValueChangedEvent += OnCoinsValueChangedEvent;
            _bank.OnCoinsValueChangedActionEvent += OnCoinsValueChangedActionEvent;
        }

        private void OnCoinsValueChangedEvent(object sender, int oldCoinsValue, int newCoinsValue)
        {
            Debug.Log($"Coins received from {sender.GetType()}, oldValue = {oldCoinsValue}, newCoinsValue = {newCoinsValue}");
        }

        private void OnCoinsValueChangedActionEvent(object sender, int oldCoinsValue, int newCoinsValue)
        {
            Debug.Log($"Coins received from ACTION {sender.GetType()}, oldValue = {oldCoinsValue}, newCoinsValue = {newCoinsValue}");
        }
    }
}