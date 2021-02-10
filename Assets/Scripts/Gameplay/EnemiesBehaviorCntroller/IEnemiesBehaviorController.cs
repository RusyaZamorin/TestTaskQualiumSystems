using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public interface IEnemiesBehaviorController
    {
        void Init(IEnemySpawner enemySpawner);

        void SetStartParametrs(float currentEnemiesSpeed, float speedChangeStep, float timeIntervalSpeedChange);

        void StartSpeedIncreaseCycle();

        void StopSpeedIncreaseCycle();
    }
}

