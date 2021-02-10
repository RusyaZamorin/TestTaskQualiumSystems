using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class Player : MonoBehaviour, IPlayer
    {
        [SerializeField] Rigidbody2D _rigidbody;
        [SerializeField] private float _moveSpeed = 8f;
        private Vector3 _moveDirection = Vector3.right;

        public event Action OnCreate;
        public event Action OnDestroy;
        public event Action OnCollisionWithEnemy;

        public void Init()
        {
            gameObject.SetActive(true);

            OnCreate?.Invoke();
        }

        public void Destroy()
        {
            gameObject.SetActive(false);

            OnDestroy?.Invoke();
        }

        public void MoveLeft()
        {
            if (_moveDirection != Vector3.left)
                _moveDirection = Vector3.left;

            Move();
        }

        public void MoveRight()
        {
            if (_moveDirection != Vector3.right)
                _moveDirection = Vector3.right;

            Move();
        }

        private void Move()
        {
            if(gameObject.activeInHierarchy)
                transform.Translate(_moveDirection * _moveSpeed * Time.fixedDeltaTime);
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {            
            if (col.gameObject.CompareTag("enemy"))
            {               
                OnCollisionWithEnemy?.Invoke();
                Destroy();
            }                
        }
    }
}