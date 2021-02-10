using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public interface IPhysicalScreen : IDefaultInitialized
    {
        Rect GetBoundsRect();        
    }
}

