using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class TankView : MonoBehaviour
    {
        [SerializeField]private Rigidbody rb;
        public Rigidbody Rb
        {
            get
            {
                if (!rb)
                {
                    rb = GetComponent<Rigidbody>();
                }
                return rb;
            }
        }
        [SerializeField]private float movement;
        [SerializeField]private float rotation;
        private TankController _tankController;
        public TankController TankController
        {
            get => _tankController;
            set
            {
                if (_tankController != null)
                {
                    throw new Exception("TankController already set");
                }
                _tankController = value;
            }
        }

        private void Start()
        {
            GameObject cam = Camera.main.gameObject;
            cam.transform.parent = transform;
            cam.transform.position = new Vector3(transform.position.x, cam.transform.position.y+3f, transform.position.z-4f);
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            movement = Input.GetAxis("Vertical");
            rotation = Input.GetAxis("Horizontal");
            if (movement != 0)
            {
                _tankController.MoveTank(movement,_tankController.TankModel.MovementSpeed);
            }

            if (rotation != 0)
            {
                _tankController.RotateTank(rotation,_tankController.TankModel.RotationSpeed);
            }
        }
    }
}
