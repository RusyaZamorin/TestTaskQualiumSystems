using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Gameplay
{
    public interface IPlayer : IDefaultInitialized
    {
        event Action OnCreate;
        event Action OnDestroy;
        event Action OnCollisionWithEnemy;


        void Destroy();

        void MoveLeft();

        void MoveRight();
    }


}
