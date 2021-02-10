using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class PhysicalScreenBounds : MonoBehaviour, IPhysicalScreen
    {
        [SerializeField] Transform _leftBound;
        [SerializeField] Transform _rightBound;

        private Rect _rect;

        public void Init()
        {
            var camera = Camera.main;

            var maxPoint = camera.ViewportToWorldPoint(Vector2.one);
            var minPoint = camera.ViewportToWorldPoint(Vector2.zero);
            
            _rect = new Rect(minPoint.x, minPoint.y, maxPoint.x - minPoint.x, maxPoint.y - minPoint.y);

            _leftBound.localPosition = Vector3.right * _rect.xMin;
            _rightBound.localPosition = Vector3.right * _rect.xMax;
        }

        public Rect GetBoundsRect()
        {
            return _rect;
        }
        
    }
}

