using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;
using InputModule;

public class ManagersInitializer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private PhysicalScreenBounds _physicalScreenBounds;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private EnemiesBehaviorController _enemiesBehaviorController;
    private void InitializeManagers()
    {
        _physicalScreenBounds.Init();

        _player?.Init();
        _enemySpawner?.Init(_physicalScreenBounds);
        _inputHandler?.Init(_player);

        _enemiesBehaviorController.Init(_enemySpawner);

        _enemySpawner.StartSpawn();
        _enemiesBehaviorController.StartSpeedIncreaseCycle();

        RegisterManager<IPhysicalScreenBounds>(_physicalScreenBounds);
        RegisterManager<IPlayer>(_player);
        RegisterManager<IEnemySpawner>(_enemySpawner);
        RegisterManager<IEnemiesBehaviorController>(_enemiesBehaviorController);
        RegisterManager<IInputHandler>(_inputHandler);
    }
    
    private void Awake()
    {
        InitializeManagers();
    }
    
    private void RegisterManager<T>(T manager)
    {
        ManagersContainer.AddManager(manager);
    }
}


