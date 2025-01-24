using UnityEngine;

namespace Observer
{
    public class GameOverUI : MonoBehaviour
    {
        private void Start()
        {
            PlayerHealth playerHealth = FindAnyObjectByType<PlayerHealth>();
            playerHealth.OnPlayerDeath += ShowGameOverUI;
        }

        private void OnDestroy()
        {
            PlayerHealth playerHealth = FindAnyObjectByType<PlayerHealth>();
            if (playerHealth != null )
            {
                playerHealth.OnPlayerDeath -= ShowGameOverUI;
            }
        }

        private void ShowGameOverUI()
        {
            Debug.Log("UI Game Over");
        }
    }
}