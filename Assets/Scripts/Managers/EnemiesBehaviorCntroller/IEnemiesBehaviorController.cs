using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public interface IEnemiesBehaviorController
    {
        void Init(IEnemySpawner enemySpawner);

        void SetStartParametrs(float currentEnemiesSpeed, float speedChangeStep, float timeIntervalSpeedChange);

        void StartSpeedIncreaseCycle();

        void StopSpeedIncreaseCycle();
    }
}

