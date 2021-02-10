using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class ManagersInitializer : MonoBehaviour
    {
        [SerializeField] Player _player;
        [SerializeField] InputHandler _inputHandler;
        [SerializeField] PhysicalScreenBounds _physicalScreenBounds;
        [SerializeField] EnemySpawner _enemySpawner;
        private void Init()
        {
            _physicalScreenBounds.Init();
            
            _player?.Init();

            _enemySpawner?.Init(_physicalScreenBounds);
            _enemySpawner.StartSpawn();
            _inputHandler?.Init(_player);
        }

        private void Awake()
        {
            Init();
        }
    }
}


