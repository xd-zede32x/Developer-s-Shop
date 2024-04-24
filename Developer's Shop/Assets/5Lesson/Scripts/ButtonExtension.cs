using UnityEngine.UI;
using UnityEngine.Events;

namespace FiveLessons
{
    public static class ButtonExtension 
    {
        public static void AddListener(this Button button, UnityAction callback) => button?.onClick.AddListener(callback);

        public static void RemoveListener(this Button button, UnityAction callback) =>  button?.onClick.RemoveListener(callback);

        public static void RemoveAllListeners(this Button button) => button?.onClick.RemoveAllListeners();
    }
}   