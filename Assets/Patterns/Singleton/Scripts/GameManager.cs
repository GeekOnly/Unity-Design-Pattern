using TMPro;
using UnityEngine;

namespace Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public int score = 0;
        public TextMeshProUGUI textScore;

        public void AddScore(int points)
        {
            score += points;
            textScore.text = score.ToString();
        }
    }
}