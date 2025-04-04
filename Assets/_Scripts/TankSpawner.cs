using UnityEngine;

namespace _Scripts
{
    public class TankSpawner : MonoBehaviour
    {
        public TankView tankView; // Reference to the tank prefab

        void Start()
        {
            CreateTank();
        }

        void CreateTank()
        {
            TankModel tankModel = new (30,20);
            TankController tankController = new (tankModel, tankView);
        
        }
    }
}

