using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameForInternship
{
    public class ButtonInGame : MonoBehaviour
    {
        [SerializeField] private GameObject _clueGameObject;

        public void Replay()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Clue()
        {
            if (_clueGameObject.activeInHierarchy)
            {
                _clueGameObject.SetActive(false);
            }
            else
            {
                _clueGameObject.SetActive(true);
            }
        }

        public void Menu()
        {
            SceneManager.LoadScene(0);
        }
    }
}
