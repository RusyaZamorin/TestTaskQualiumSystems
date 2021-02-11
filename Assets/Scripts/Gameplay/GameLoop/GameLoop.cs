using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class GameLoop : IGameLoop
    {
        private IPlayer _player;
        private IEnemySpawner _enemySpawner;
        private IEnemiesBehaviorController _enemiesBehaviorController;

        public event Action OnStartGame;
        public event Action OnEndGame;
        public event Action OnRestartGame;

        public void Init(IPlayer player, IEnemySpawner enemySpawner, IEnemiesBehaviorController enemiesBehaviorController)
        {
            _player = player;
            _enemySpawner = enemySpawner;
            _enemiesBehaviorController = enemiesBehaviorController;

            _player.OnCollisionWithEnemy += EndGame;
        }

        public void StartGame()
        {
            RunGameActions();

            OnStartGame?.Invoke();
        }

        public void RestartGame()
        {
            RunGameActions();

            OnRestartGame?.Invoke();
        }

        public void EndGame()
        {            
            _enemySpawner.StopSpawn();
            _enemiesBehaviorController.StopSpeedIncreaseCycle();
            _enemiesBehaviorController.DeactivateAllEnemies();

            OnEndGame?.Invoke();
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        private void RunGameActions()
        {
            _player.Init();
            _enemySpawner.StartSpawn();

            _enemiesBehaviorController.ResetToStartSpeedSetting();
            _enemiesBehaviorController.StartSpeedIncreaseCycle();
        }
    }
}


