using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameForInternship
{
    public class UIMainMenu : MonoBehaviour
    {
        private readonly PlayerPrefsString _playerPrefsString = new PlayerPrefsString();

        private void Awake()
        {
            if (!PlayerPrefs.HasKey(_playerPrefsString.LastOpenLevel))
            {
                PlayerPrefs.SetInt(_playerPrefsString.LastOpenLevel, 1);
            }
        }

        public void Play()
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt(_playerPrefsString.LastOpenLevel));
        }

        public void ResetAllProgress()
        {
            PlayerPrefs.SetInt(_playerPrefsString.LastOpenLevel, 1);
        }
    }
}
