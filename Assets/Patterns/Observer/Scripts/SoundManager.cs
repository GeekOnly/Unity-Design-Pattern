using UnityEngine;

namespace Observer
{
    public class SoundManager : MonoBehaviour
    {
        void Start()
        {
            PlayerHealth playerHealth = FindAnyObjectByType<PlayerHealth>();
            playerHealth.OnPlayerDeath += PlayGameOverSound;
            playerHealth.OnDamageTaken += PlayDamageSound;
        }

        private void OnDestroy()
        {
            PlayerHealth playerHealth = FindAnyObjectByType<PlayerHealth>();
            if (playerHealth != null )
            {
                playerHealth.OnPlayerDeath -= PlayGameOverSound;
                playerHealth.OnDamageTaken -= PlayDamageSound;
            }
        }

        private void PlayGameOverSound()
        {
            Debug.Log("Game Over Sound!");
        }

        private void PlayDamageSound(int damage)
        {
            Debug.Log($"Play Sound Damage{damage}");
        }
    }
}
