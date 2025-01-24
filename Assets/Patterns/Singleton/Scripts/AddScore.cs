using UnityEngine;

namespace Singleton
{
    public class AddScore : MonoBehaviour
    {
        public void AddScoreFun() {
            GameManager.instance.AddScore(1);
        }
    }
}
