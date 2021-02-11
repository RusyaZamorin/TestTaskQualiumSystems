using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace Visual
{
    public class StartButton : MonoBehaviour
    {
        private void Start()
        {
            ManagersContainer.GetManager<IGameLoop>().OnStartGame += OfButton;
        }

        private void OfButton() => gameObject.SetActive(false);
        
    }
}


