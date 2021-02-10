using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public interface IPhysicalScreen : IManager
    {
        Rect GetBoundsRect();        
    }
}

