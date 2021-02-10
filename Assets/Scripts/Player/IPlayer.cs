using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IPlayer
{
    event Action OnCreate;
    event Action OnDestroy;
    event Action OnCollisionWithEnemy;    

    void Init();

    void Destroy();

    void MoveLeft();

    void MoveRight();    
}

