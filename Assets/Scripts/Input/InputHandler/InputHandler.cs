using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace InputModule
{
    public class InputHandler : MonoBehaviour
    {
        private IPlayer _player;

        public void Init(IPlayer player) => _player = player;        

        private void HandleTouch()
        {                        
            if(Input.GetKey(KeyCode.D))
            {                
                _player.MoveRight();
            }
            else if (Input.GetKey(KeyCode.A))
            {                
                _player.MoveLeft();
            }
        }

        private void FixedUpdate()
        {            
            HandleTouch();
        }
    }
}

