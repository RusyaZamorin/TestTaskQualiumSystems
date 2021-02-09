using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameLoop : IGameLoop
    {
        public event Action OnStartGame;
        public event Action OnEndGame;


        public void Init()
        {

        }

        public void StartGame()
        {
            OnStartGame?.Invoke();
        }

        public void RestartGame()
        {

        }

        public void EndGame()
        {
            OnEndGame?.Invoke();
        }              
    }
}


