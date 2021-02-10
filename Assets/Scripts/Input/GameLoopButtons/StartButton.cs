using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace InputModule
{
    public class StartButton : MonoBehaviour
    {        
        private void Start()
        {
            ManagersContainer.GetManager<IGameLoop>().OnStartGame += SetDisactiveButton;            
        }

        public void StartGame() => ManagersContainer.GetManager<IGameLoop>().StartGame();

        private void SetDisactiveButton()
        {
            gameObject.SetActive(false);
        }
    }
}

