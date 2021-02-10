using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class ManagersInitializer : MonoBehaviour
    {
        [SerializeField] Player _player;
        [SerializeField] InputHandler _inputHandler;
        
        private void Init()
        {
            _player?.Init();
            _inputHandler?.Init(_player);
        }

        private void Awake()
        {
            Init();
        }
    }
}


