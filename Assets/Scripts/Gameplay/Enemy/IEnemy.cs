using System;

namespace Gameplay
{
    public interface IEnemy
    {
        event Action OnDestroy;

        void Destroy();

        void SetSpeed(float speed);

    }
}