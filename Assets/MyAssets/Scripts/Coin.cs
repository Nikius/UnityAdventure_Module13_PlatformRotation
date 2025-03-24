using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Ball ball = other.GetComponent<Ball>();

            if (ball == null)
                return;
            
            ball.Collect();
            gameObject.SetActive(false);
        }

        public void Reset()
        {
            gameObject.SetActive(true);
        }
    }
}
