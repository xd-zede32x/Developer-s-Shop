using UnityEngine;

namespace OneLesson
{
    public class SpyCar : BaseCar
    {
        private void SetVisibility(bool enabled) => Debug.Log($"SpyCar visibility enabled: {enabled}");
    }
}