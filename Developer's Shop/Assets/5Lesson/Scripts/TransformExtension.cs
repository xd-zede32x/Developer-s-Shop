using UnityEngine;

namespace FiveLessons
{
    public static class TransformExtension
    {
        public static void Destroy(this Transform transform) => Object.Destroy(transform.gameObject);

        public static void Activate(this Transform transform) => transform.gameObject.SetActive(true);

        public static void Deactivate(this Transform transform) => transform.gameObject.SetActive(false);
    }
}