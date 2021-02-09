using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public static class ManagersContainer 
    {
        private static Dictionary<object, object> _managers = new Dictionary<object, object>();
        

        public static T AddManager<T>(T service)
        {
            if (!_managers.ContainsKey(service))
            {
                _managers.Add(typeof(T), service);
                return service;
            }

            return default;
        }

        public static T GetManager<T>()
        {
            if (_managers.ContainsKey(typeof(T)))
                return (T)_managers[typeof(T)];

            return default;
        }
    }
}

