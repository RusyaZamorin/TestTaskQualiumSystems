using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Managers
{
    public interface IGameLoop : IManager
    {
        event Action OnStartGame;        
        event Action OnEndGame;        

        void StartGame();

        void EndGame();

        void RestartGame();
    }
}

