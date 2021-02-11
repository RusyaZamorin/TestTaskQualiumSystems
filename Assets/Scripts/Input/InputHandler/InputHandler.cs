using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace InputModule
{
    public class InputHandler : MonoBehaviour, IInputHandler
    {
        private IPlayer _player;
        private float xCentrPoint;

        public void Init(IPlayer player)
        {
            _player = player;

            xCentrPoint = Screen.width / 2f;
        }

        private void HandleTouch()
        {                        
            if(Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                Debug.Log(touch.position);

                if (touch.position.x < xCentrPoint)
                    _player.MoveLeft();
                else
                    _player.MoveRight();
            }
        }

        private void FixedUpdate()
        {            
            HandleTouch();
        }
    }
}

