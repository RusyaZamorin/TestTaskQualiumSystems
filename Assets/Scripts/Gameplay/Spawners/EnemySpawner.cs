﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class EnemySpawner : MonoBehaviour, IEnemySpawner
    {
        [SerializeField] GameObject _enemyPrefab;
        [SerializeField] Transform _enemyContainer;
        [Header("Spawn interwal in seccond")]
        [SerializeField] float _spawnInterval = 5f;
        [SerializeField] float yUpOffset = 0.5f;

        private Rect _spawnBounds;
        private Vector2 _halfEnemySize;
        private ObjectPool _enemyPool;
        private float ySpawnPosition;

        public event System.Action<IEnemy> OnCreateEnemy;

        public void Init(PhysicalScreenBounds physicalScreenBounds)
        {
            _spawnBounds = physicalScreenBounds.GetBoundsRect();

            _halfEnemySize = (_enemyPrefab.GetComponent<SpriteRenderer>().bounds.size) / 2f;
            
            _enemyPool = new ObjectPool();

            ySpawnPosition = _spawnBounds.yMax + _halfEnemySize.y + yUpOffset;
        }
    

        public void CreateEnemy()
        {            
            float xPosition = Random.Range(_spawnBounds.xMin + _halfEnemySize.x, _spawnBounds.xMax - _halfEnemySize.x);
            Vector3 position = new Vector3(xPosition, ySpawnPosition, 0f);            
            
            var enemyObj = _enemyPool.TakeObject(_enemyPrefab, position, Quaternion.identity, _enemyContainer);

            OnCreateEnemy?.Invoke(enemyObj.GetComponent<IEnemy>());
        }

        public void StartSpawn() => StartCoroutine(Spawn());

        public void StopSpawn() => StopAllCoroutines();        

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

