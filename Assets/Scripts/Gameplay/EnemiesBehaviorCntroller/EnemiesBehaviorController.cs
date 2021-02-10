using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class EnemiesBehaviorController : MonoBehaviour, IEnemiesBehaviorController
    {
        
        [SerializeField] private float _timeIntervalSpeedChange = 5f;
        [SerializeField] private float _currentEnemiesSpeed = 3f;
        [SerializeField] private float _speedChangeStep = 0.2f;
        
        private List<IEnemy> _enemies;

        public void Init(IEnemySpawner enemySpawner)
        {            
            _enemies = new List<IEnemy>();

            enemySpawner.OnCreateEnemy += AddEnemyToList;
        }

        public void SetStartParametrs(float currentEnemiesSpeed, float speedChangeStep, float timeIntervalSpeedChange)
        {
            _currentEnemiesSpeed = currentEnemiesSpeed;
            _speedChangeStep = speedChangeStep;
            _timeIntervalSpeedChange = timeIntervalSpeedChange;
        }

        public void StartSpeedIncreaseCycle() => StartCoroutine(SpeedIncreaseCycle());        

        public void StopSpeedIncreaseCycle() => StopCoroutine(SpeedIncreaseCycle());

        private void AddEnemyToList(IEnemy enemy)
        {
            if (_enemies.Contains(enemy) == false)
            {
                _enemies.Add(enemy);
                enemy.SetSpeed(_currentEnemiesSpeed);
            }
        }   
        
        private IEnumerator SpeedIncreaseCycle()
        {
            while(true)
            {
                _currentEnemiesSpeed += _speedChangeStep;

                foreach (var enemy in _enemies)
                    enemy.SetSpeed(_currentEnemiesSpeed);
                
                yield return new WaitForSeconds(_timeIntervalSpeedChange);
            }
        }
    }
}

