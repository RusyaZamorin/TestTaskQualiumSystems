using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public interface IEnemySpawner
    {
        void Init(PhysicalScreenBounds physicalScreenBounds);

        void CreateEnemy();

        void StartSpawn();

        void StopSpawn();
    }
}


