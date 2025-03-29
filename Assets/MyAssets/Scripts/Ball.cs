using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Ball : MonoBehaviour
    {
        private Vector3 _startPosition;
        public Wallet wallet;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        public void Reset()
        {
            wallet.Reset();
            transform.position = _startPosition;
        }
    }
}
