
using UnityEngine;

namespace _Scripts
{
    public class TankSelection : MonoBehaviour
    {
        [SerializeField] private TankSpawner tankSpawner;
        public void BlueTank()
        {
            tankSpawner.CreateTank(TankTypes.Blue);
        }
        public void RedTank()
        {
            tankSpawner.CreateTank(TankTypes.Red);
        }
        public void GreenTank()
        {
            tankSpawner.CreateTank(TankTypes.Green);
        }
    }
}
