using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Managers
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


