using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Gameplay
{
    public interface IEnemySpawner
    {
        event Action<IEnemy> OnCreateEnemy;

        void Init(PhysicalScreenBounds physicalScreenBounds);

        void CreateEnemy();

        void StartSpawn();

        void StopSpawn();        
    }
}


