﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public interface IPlayerSpawner : IManager
    {
        void CreatePlayer();
    }
}
