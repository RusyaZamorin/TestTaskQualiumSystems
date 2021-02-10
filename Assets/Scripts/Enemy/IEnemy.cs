using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IEnemy 
{
    event Action OnDestroy;    

    void Destroy();

    void SetSpeed(float speed); 
        
}
