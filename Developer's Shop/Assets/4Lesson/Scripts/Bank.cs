using UnityEngine;

namespace FourLessons
{
    public class Bank : MonoBehaviour
    {
        public static Bank Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bank();

                return _instance;
            }
        }

        private static Bank _instance;

        public int Coins { get; private set; }

        public void Debug() => UnityEngine.Debug.Log("Bank Singleton");
    }
}