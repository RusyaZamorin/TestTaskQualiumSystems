using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{    
    private float _moveSpeed = 0f;
    private Vector3 _moveDirection = Vector3.down;

    public event Action OnDestroy;

    public void Destroy()
    {        
        gameObject.SetActive(false);

        OnDestroy?.Invoke();
    }

    public void SetSpeed(float speed) => _moveSpeed = speed;

    private void Move()
    {
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Move();
    }
}
