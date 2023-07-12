using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameForInternship
{
    public class UIGame : MonoBehaviour
    {
        public void Menu()
        {
            SceneManager.LoadScene(0);
        }

        public void Replay()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Next()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
