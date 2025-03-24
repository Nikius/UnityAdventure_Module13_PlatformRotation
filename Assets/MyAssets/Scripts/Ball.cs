using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody _rigidbody;
    
        [SerializeField] private float _jumpForce;
        
        private Vector3 _startPosition;

        public int CollectedCoins { get; private set; }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _startPosition = transform.position;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }

        public void Collect()
        {
            CollectedCoins++;
            Debug.Log($"Collected coins: {CollectedCoins}");
        }

        public void Reset()
        {
            CollectedCoins = 0;
            transform.position = _startPosition;
        }
    }
}
