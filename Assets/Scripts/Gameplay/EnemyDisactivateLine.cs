using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class EnemyDisactivateLine : MonoBehaviour
    {
        [SerializeField] private float _offset = 1f;


        private void SetStartPosition()
        {
            var physicalScreenBounds = ManagersContainer.GetManager<IPhysicalScreenBounds>();
            transform.localPosition = new Vector3(0, physicalScreenBounds.GetBoundsRect().yMin - _offset, 0f);
        }

        private void Start()
        {
            SetStartPosition();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("enemy"))
            {
                col.gameObject.SetActive(false);
            }
        }
        
    }
}