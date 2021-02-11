using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gameplay;

namespace Visual
{
    public class RestartPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _panelContent;

        private void Start()
        {
            var gameLoop = ManagersContainer.GetManager<IGameLoop>();
            gameLoop.OnEndGame += ShowContent;
            gameLoop.OnRestartGame += HideContent;
        }

        private void HideContent() => _panelContent.SetActive(false);

        private void ShowContent() => _panelContent.SetActive(true);

    }
}
