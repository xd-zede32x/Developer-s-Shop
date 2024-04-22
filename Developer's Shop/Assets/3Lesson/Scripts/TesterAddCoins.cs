using UnityEngine;
using System.Collections.Generic;

namespace ThreeLesson
{
    public class TesterAddCoins : MonoBehaviour
    {
        private Bank _bank;
        private List<TesterCoinsBase> _testers;

        private TesterCoinsPanel _coinsPanel;

        private void Awake()
        {
            _bank = new Bank();
            _coinsPanel = new TesterCoinsPanel(_bank);

            _testers = new List<TesterCoinsBase>
            {
                new TesterCoin(_bank),
                new TesterReward(_bank),
                new TesterPurchase(_bank)
            };
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                AddRandomCoins();
        }

        private void AddRandomCoins()
        {
            var randomIndex = Random.Range(0, _testers.Count);
            var randomTester = _testers[randomIndex];

            randomTester.TestAddCoinsToBank();
        }
    }
}