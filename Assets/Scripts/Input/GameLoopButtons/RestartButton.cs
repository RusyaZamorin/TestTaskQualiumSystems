using UnityEngine;
using Gameplay;

namespace InputModule
{
    public class RestartButton : MonoBehaviour
    {
        [SerializeField] GameObject _button;

        private void Start()
        {
            ManagersContainer.GetManager<IGameLoop>().OnRestartGame += SetDisactiveButton;
            ManagersContainer.GetManager<IGameLoop>().OnEndGame += SetActiveButton;            
        }

        public void RestartGame() => ManagersContainer.GetManager<IGameLoop>().RestartGame();

        private void SetDisactiveButton()
        {
            _button.SetActive(false);
        }

        private void SetActiveButton()
        {
            _button.SetActive(true);
        }
    }
}