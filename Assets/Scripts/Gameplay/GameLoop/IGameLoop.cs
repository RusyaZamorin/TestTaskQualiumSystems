using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Gameplay
{
    public interface IGameLoop
    {
        event Action OnStartGame;        
        event Action OnEndGame;
        event Action OnRestartGame;

        void Init(IPlayer player, IEnemySpawner enemySpawner, IEnemiesBehaviorController enemiesBehaviorController);

        void StartGame();

        void EndGame();

        void RestartGame();
    }
}

