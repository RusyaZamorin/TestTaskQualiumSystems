using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Gameplay
{
    public interface IGameLoop : IDefaultInitialized
    {
        event Action OnStartGame;        
        event Action OnEndGame;        

        void StartGame();

        void EndGame();

        void RestartGame();
    }
}

