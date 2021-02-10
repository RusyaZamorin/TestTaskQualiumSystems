using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisactivateLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            col.gameObject.SetActive(false);
        }
    }
}
