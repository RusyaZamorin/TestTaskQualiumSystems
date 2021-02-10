using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public interface IEnemiesBehaviorController
    {
        void Init(IEnemySpawner enemySpawner);

        void ResetToStartSpeedSetting();

        void StartSpeedIncreaseCycle();

        void StopSpeedIncreaseCycle();
    }
}

