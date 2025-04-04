using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts
{
    public class TankSpawner : MonoBehaviour
    {
        [Serializable]public class Tank
        {
            public TankTypes tankType;
            public float movementSpeed;
            public float rotationSpeed;
            public Color color;
        }
        [SerializeField]List<Tank> tanks;
        
        public TankView tankView; // Reference to the tank prefab

        void Start()
        {
        }

        public void CreateTank(TankTypes tankType)
        {
            TankModel tankModel = new (tanks[(int)tankType]);
            TankController tankController = new (tankModel, tankView);
        
        }
    }
}

