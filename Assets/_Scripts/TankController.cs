using UnityEngine;

namespace _Scripts
{
    public class TankController
    {
        public TankModel TankModel { get; }
        private readonly TankView _tankView;
        private readonly Rigidbody _rb;
        
        public TankController(TankModel model, TankView view)
        {
            TankModel = model;
            _tankView = Object.Instantiate<TankView>(view);
            _rb = _tankView.Rb;
            TankModel.TankController = this;
            _tankView.TankController = this;
            
        }

        public void MoveTank(float movement, float movementSpeed)
        {
            _rb.linearVelocity = movement * movementSpeed *_tankView.transform.forward; 
        }
        public void RotateTank(float rotation, float rotationSpeed)
        {
            Vector3 dir = new(0f,rotation * rotationSpeed,0f);
            Quaternion deltaRotation = Quaternion.Euler(dir*Time.deltaTime);
            _rb.MoveRotation(_rb.rotation * deltaRotation);
        }
        
    }
}
