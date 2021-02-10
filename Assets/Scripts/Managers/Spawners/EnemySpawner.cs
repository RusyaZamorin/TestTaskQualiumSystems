using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class EnemySpawner : MonoBehaviour, IEnemySpawner
    {
        [SerializeField] GameObject _enemyPrefab;
        [SerializeField] Transform _enemyContainer;
        [Header("Spawn interwal in seccond")]
        [SerializeField] float _spawnInterval = 5f;

        private Rect _spawnBounds;
        private Vector2 _halfEnemySize;
        private ObjectPool _enemyPool;

        public event System.Action<IEnemy> OnCreateEnemy;

        public void Init(PhysicalScreenBounds physicalScreenBounds)
        {
            _spawnBounds = physicalScreenBounds.GetBoundsRect();

            _halfEnemySize = (_enemyPrefab.GetComponent<SpriteRenderer>().size * _enemyPrefab.transform.localScale) / 2f;

            _enemyPool = new ObjectPool();
        }
    

        public void CreateEnemy()
        {            
            float xPosition = Random.Range(_spawnBounds.xMin + _halfEnemySize.x, _spawnBounds.xMax - _halfEnemySize.x);
            Vector3 position = new Vector3(xPosition, _spawnBounds.yMax + _halfEnemySize.y, 0f);

            var enemyObj = _enemyPool.TakeObject(_enemyPrefab, position, Quaternion.identity, _enemyContainer);

            OnCreateEnemy?.Invoke(enemyObj.GetComponent<IEnemy>());
        }

        public void StartSpawn()
        {
            StartCoroutine(Spawn());
        }

        public void StopSpawn()
        {
            StopCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while(true)
            {
                CreateEnemy();
                yield return new WaitForSeconds(_spawnInterval);
            }
        }
    }
}

