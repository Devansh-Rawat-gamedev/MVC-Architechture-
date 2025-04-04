using UnityEngine;

namespace _Scripts
{
    public class TankModel
    {
        private TankController _tankController;

        public TankController TankController
        {
            get => _tankController;
            set
            {
                if (_tankController != null)
                {
                    throw new System.Exception("TankController already set");
                }

                _tankController = value;
            }
        }

        public readonly float MovementSpeed;
        public readonly float RotationSpeed;
        public readonly Color Color;

        public TankModel(TankSpawner.Tank tank)
        {
            MovementSpeed = tank.movementSpeed;
            RotationSpeed = tank.rotationSpeed;
            Color= tank.color;
        }
    }
}
