using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace InputModule
{
    public class GameLoopDelegator : MonoBehaviour
    {
        public void StartGame() => FindGameLoop().StartGame();

        public void RestartGame() => FindGameLoop().RestartGame();

        public void EndGame() => FindGameLoop().EndGame();

        public void QuitGame() => FindGameLoop().QuitGame();

        private IGameLoop FindGameLoop() => ManagersContainer.GetManager<IGameLoop>();
    }
}

