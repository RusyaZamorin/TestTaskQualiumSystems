using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public interface IPhysicalScreenBounds : IDefaultInitialized
    {
        Rect GetBoundsRect();        
    }
}

