using System;
using UnityEngine;

namespace Observer
{
    public class PlayerHealth : MonoBehaviour
    {
        public event Action OnPlayerDeath;
        public event Action<int> OnDamageTaken;

        private int health = 100;

        public void TakeDamage(int damage)
        {
            if (health > 0)
            {
                health -= damage;
                Debug.Log("Player health: " + health);

                OnDamageTaken?.Invoke(damage);

                if (health <= 0)
                {
                    OnPlayerDeath?.Invoke();
                }
            } 
        }
    }
}