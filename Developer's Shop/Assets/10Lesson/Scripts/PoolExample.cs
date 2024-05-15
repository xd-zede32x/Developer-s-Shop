using UnityEngine;

namespace TensLessons
{
    public class PoolExample : MonoBehaviour
    {
        [SerializeField] private int _poolCount;
        [SerializeField] private bool _autoExpand = false;
        [SerializeField] private Cube _cubePrefab;

        private PoolMono<Cube> _pool;

        private void Start()
        {
            _pool = new PoolMono<Cube>(_cubePrefab, _poolCount, transform);
            _pool.AutoExpand = _autoExpand;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                CreateCube();
        }

        private void CreateCube()
        {
            var randomX = Random.Range(-5f, 5f);
            var randomZ = Random.Range(-5f, 5f);

            var y = 0;

            var randomPosition = new Vector3(randomX, y, randomZ);

            var cube = _pool.GetFreeElement();

            cube.transform.position = randomPosition;
        }
    }
}